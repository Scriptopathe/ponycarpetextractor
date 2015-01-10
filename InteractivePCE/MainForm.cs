using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using System.IO;
using PonyCarpetExtractor.ExpressionTree;
using PonyCarpetExtractor;
namespace InteractiveInterpreter
{
    public partial class MainForm : Form
    {
        #region Properties
        /// <summary>
        /// Instance de l'interpréteur.
        /// </summary>
        public static Interpreter Interpreter
        {
            get;
            set;
        }
        /// <summary>
        /// Donne accès au Singleton de la MainForm.
        /// </summary>
        public static MainForm Singleton
        {
            get;
            set;
        }
        /// <summary>
        /// Donne accès au code de la textbox.
        /// </summary>
        public string Code
        {
            get { return m_codeTextbox.Text; }
            set { m_codeTextbox.Text = value; }
        }

        #endregion

        /// <summary>
        /// Crée une nouvelle mainform
        /// </summary>
        public MainForm()
        {
            if (Singleton != null)
                throw new Exception("C'est un singleton, BANANE !");
            Singleton = this;

            // Setup de l'interpréteur.
            Interpreter = new Interpreter();
            Interpreter.OnPuts = new PonyCarpetExtractor.Interpreter.PutsDelegate(Puts);
            Interpreter.OnError = new PonyCarpetExtractor.Interpreter.PutsDelegate(PutsError);
            // Setup de la fenêtre
            InitializeComponent();
            InitializeEvents();
            this.Icon = Properties.Resources.geomlogo1;
        }
        /// <summary>
        /// Ajoute l'objet donné à la console.
        /// </summary>
        void Puts(string str)
        {
            m_consoleTextbox.AppendText(str.ToString() + "\n");
        }
        /// <summary>
        /// Vide la console de son texte.
        /// </summary>
        void ClearConsole()
        {
            m_consoleTextbox.Text = "";
        }
        /// <summary>
        /// Affiche une erreur dans la console d'erreurs.
        /// </summary>
        /// <param name="err"></param>
        void PutsError(string err)
        {
            m_errorsTextbox.Text = err;
            m_tabControl.SelectedIndex = 2;
        }
        /// <summary>
        /// Initialize les évènements
        /// </summary>
        void InitializeEvents()
        {
            m_exeButton.Click += new EventHandler(OnDrawClicked);

            // Allez on charge tout ce bordel et c'est bon.
            string dir = "res\\"; 
            FileSyntaxModeProvider fsmProvider;
            if (Directory.Exists(dir))
            {
                fsmProvider = new FileSyntaxModeProvider(dir); 
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmProvider);
                m_codeTextbox.SetHighlighting("geom");
            }
        }

        /// <summary>
        /// Crée le dessin
        /// </summary>
        void OnDrawClicked(object sender, EventArgs e)
        {
            Interpreter.Reset();
            Interpreter.Eval(m_codeTextbox.Text);
            MainForm.Singleton.UpdateStatusList(Interpreter.MainContext);
        }

        /// <summary>
        /// Mets à jour la fenêtre de status.
        /// </summary>
        public void UpdateStatusList(PonyCarpetExtractor.ExpressionTree.Context context)
        {
            m_statusList.ShowGroups = true;
            m_statusList.Items.Clear();
            m_statusList.Groups.Add(new ListViewGroup("Variables"));
            m_statusList.Groups.Add(new ListViewGroup("Fonctions"));
            foreach (KeyValuePair<string, Mutable> kvp in context.LocalVariables)
            {
                ListViewItem item;
                int grp = kvp.Value.Value is Function ? 1 : 0;
                try
                {
                    
                    item = new ListViewItem(new string[] { 
                        kvp.Key, 
                        kvp.Value.Value.ToString(),
                        kvp.Value.Value.GetType().Name}, m_statusList.Groups[grp]);
                }
                catch
                {
                    // Si le la valeur vaut null une exception est levée
                    // et on atterrit ici.
                    item = new ListViewItem(new string[] {
                        kvp.Key,
                        "null",
                        "null"}, m_statusList.Groups[grp]);
                }
                m_statusList.Items.Add(item);
            }
        }
    }
}
