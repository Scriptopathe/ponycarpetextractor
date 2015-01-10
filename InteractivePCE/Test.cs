using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PonyCarpetExtractor.ExpressionTree;
using PonyCarpetExtractor.ExpressionTree.Instructions;
using System.Windows.Forms;
using System.Reflection;
namespace InteractiveInterpreter
{
    /// <summary>
    /// Une classe
    /// </summary>
    class TClass
    {
        public int C;
        public int D;
        public TClass(int c, int d)
        {
            C = c; D = d;
        }
    }

    /// <summary>
    /// Classe de test.
    /// </summary>
    class Test
    {
        /// <summary>
        /// Constructeur, lance les tests.
        /// </summary>
        public Test()
        {
            
            /*string type = "char[6,4]";//"List<Dictionary<string, char[][]>>[,][]";
            var c = new GlobalContext();
            Context context = new Context(c);
            Dummy.context = context;
            context.GlobalContext = c;
            context.GlobalContext.LoadedNamespaces = new List<string>();
            context.GlobalContext.LoadedNamespaces.Add("System.Collections.Generic");
            context.GlobalContext.LoadedNamespaces.Add("Geom");
            context.GlobalContext.LoadedAssemblies = new Dictionary<string, Assembly>();
            context.GlobalContext.LoadedAssemblies.Add("mscorlib", Assembly.GetAssembly(typeof(char)));
            context.GlobalContext.LoadedAssemblies.Add("local", Assembly.GetExecutingAssembly());
            context.LocalVariables = new Dictionary<string, object>();
            context.GlobalContext.Variables = new Dictionary<string, object>();
            context.LocalVariables.Add("var1", 56);*/
            /*
            // Expression complète :
            SubExpression exp = new SubExpression();
            SubExpression exp2 = new SubExpression();

            // Partie 1 : new object
            SubExpressionPart p1 = new SubExpressionPart();
            p1.Name = "TClass";
            p1.Parameters = new List<IGettable>() { new Mutable(5), new Mutable(600) };
            p1.SubExpType = SubExpressionPart.ExpTypes.NewObject;

            // Partie 2 : set value
            SubExpressionPart p2 = new SubExpressionPart();
            p2.Name = "D";
            p2.SubExpType = SubExpressionPart.ExpTypes.Variable;

            // Setup de l'expression
            exp.Parts = new List<SubExpressionPart>();
            exp.Parts.Add(p1);
            exp.Parts.Add(p2);


            // Exp 2 :
            SubExpressionPart p3 = new SubExpressionPart();
            p3.SubExpType = SubExpressionPart.ExpTypes.Variable;
            p3.Name = "var1";
            exp2.Parts = new List<SubExpressionPart>() { p3 };


            exp2.SetValue(context, exp.GetValue(context));*/

            /*
            // Variable
            SubExpressionPart part = new SubExpressionPart();
            part.Name = "var1";
            part.SubExpType = SubExpressionPart.ExpTypes.Variable;
            
            object o = part.GetObjectBoundValue(context, this);

            // Method
            SubExpressionPart part1 = new SubExpressionPart();
            part1.Name = "Method";
            part1.SubExpType = SubExpressionPart.ExpTypes.Method;
            part1.Parameters = new List<IGettable>() { new Mutable(15) };
            object o1 = part1.GetObjectBoundValue(context, this);
            */
            // Static Method
            /*DateTime t = DateTime.Now;
            SubExpressionPart part2 = new SubExpressionPart();
            part2.Name = "Assembly";
            part2.SubExpType = SubExpressionPart.ExpTypes.Variable;
            part2.Parameters = new List<IGettable>() { new Mutable(25) };
            Type myType = typeof(Test);//new InternalTypeRepresentation(this.GetType());
            object o2;

            o2 = part2.GetObjectBoundValue(context, myType);
            int s = (DateTime.Now - t).Milliseconds;*/
            /*
            SubExpressionPart part = new SubExpressionPart();
            part.SubExpType = SubExpressionPart.ExpTypes.NewObject;
            part.Name = type;
            part.Parameters = new List<IGettable>();

            object o = (char[,])part.GetObjectUnboundValue(context);

            part.SubExpType = SubExpressionPart.ExpTypes.ConstantTypeName;*/
            // object o2 = (Type)part.GetObjectUnboundValue(context);
            /*var t = global::Interpreter.ReflectionUtils.FindType(context, "default", type, false);
            object[] args = new object[t.ArraySizeParameters.Count()];
            int j = 0;
            foreach (int i in t.ArraySizeParameters) { args[j] = i; j++; }
            object o = Activator.CreateInstance(t.Type, args);
            var obj = (char[,])o;*/
        }

        /* ------------------------------------------------------------------------
         * Test methods
         * ----------------------------------------------------------------------*/
        #region Test methods
        public delegate int TestDel(int a);
        public event TestDel TestEvt;
        /// <summary>
        /// Test 2 : Events
        /// </summary>
        void Test2()
        {
            /*
            Operators.InitOperators();
            var globalContext = new GlobalContext();
            Context context = new Context(globalContext);
            Dummy.context = context;
            context.GlobalContext = globalContext;
            // On fait une Setup du context.
            globalContext.LoadedNamespaces = new List<string>();
            globalContext.LoadedNamespaces.Add("System.Collections.Generic");
            globalContext.LoadedNamespaces.Add("InteractiveInterpreter");
            globalContext.LoadedAssemblies = new Dictionary<string, Assembly>();
            globalContext.LoadedAssemblies.Add("mscorlib", Assembly.GetAssembly(typeof(char)));
            globalContext.LoadedAssemblies.Add("local", Assembly.GetExecutingAssembly());
            context.LocalVariables = new Dictionary<string, Mutable>();
            context.GlobalContext.Variables = new Dictionary<string, Mutable>();

            // Main block
            Block mainBlock = new Block(globalContext);
            mainBlock.Instructions = new List<Instruction>();
            // Instructions
            // Declaration d'un objet test :
            AffectationInstruction instr1 = new AffectationInstruction();
            instr1.LeftMember = SubExpression.Variable("test");
            instr1.RightMember = SubExpression.NewObj("Test");
            mainBlock.Instructions.Add(instr1);
            // Souscription à son event
            
            /*EventSubscribeInstruction inst = new EventSubscribeInstruction(
                SubExpression.Event("test", "TestEvt"),
                SubExpression.NewObj("TestDel", new IGettable[] { 
                new Mutable(InternalTest1)})
                );*/
        }
        public int InternalTest1(int a)
        {
            return a + 5;
        }
        /// <summary>
        /// Test 1 : on va exécuter le code suivant :
        /// Dummy dum = new Dummy()
        /// if(MainForm.Singleton.Code == "hello")
        ///     MainForm.Singleton.Code = MainForm.Singleton.Code + " World !" 
        /// else if (MainForm.Singleton.Code.Length &lt 50)
        /// {
        ///     int c = 0.89
        ///     while(MainForm.Singleton.Code.Length &lt 500)
        ///     {
        ///         c = (c+1)*c;
        ///         dum.DummyMethod(c)
        ///     }       
        ///     
        ///     dum.DummyMethod(Dummy.TypeOf("string"))
        /// }
        /// else
        ///     dum.DummyMethod("shit");
        /// </summary>
        void Test1()
        {
            Operators.InitOperators();
            var globalContext = new GlobalContext();
            Context context = new Context(globalContext);
            Dummy.context = context;
            context.GlobalContext = globalContext;
            // On fait une Setup du context.
            globalContext.LoadedNamespaces = new List<string>();
            globalContext.LoadedNamespaces.Add("System.Collections.Generic");
            globalContext.LoadedNamespaces.Add("InteractiveInterpreter");
            globalContext.LoadedAssemblies = new Dictionary<string, Assembly>();
            globalContext.LoadedAssemblies.Add("mscorlib", Assembly.GetAssembly(typeof(char)));
            globalContext.LoadedAssemblies.Add("local", Assembly.GetExecutingAssembly());
            context.LocalVariables = new Dictionary<string, Mutable>();
            context.GlobalContext.Variables = new Dictionary<string, Mutable>();
            
            // Main block
            Block mainBlock = new Block(globalContext);

            // Première instruction
            // Dummy dum = new Dummy()
            AffectationInstruction affectDum = new AffectationInstruction();
            SubExpression dummy = SubExpression.Variable("dum");
            SubExpression newDummy = new SubExpression(
                new SubExpressionPart("Dummy", SubExpressionPart.ExpTypes.NewObject));
            affectDum.LeftMember = dummy;
            affectDum.RightMember = newDummy;

            // On prépare le "if" :
            IfStatement _if = new IfStatement();
            ConditionalBlock _if1 = new ConditionalBlock();
            _if1.Block = new Block(globalContext);
            ConditionalBlock _if2 = new ConditionalBlock();
            _if2.Block = new Block(globalContext);
            Block _else = new Block(globalContext);

            _if.Blocks = new List<ConditionalBlock>() { _if1, _if2 };
            _if.ElseBlock = _else;
            
            #region Mainform.Singleton.Conde
            // Un truc qui va servir souvent :
            // MainForm.Singleton.Code
            // -------------------------------
            SubExpression mainformSingletonCode = new SubExpression();
            SubExpression mainformSingletonCodeCount = new SubExpression();

            SubExpressionPart singletonCode1 = new SubExpressionPart(
                "MainForm",
                SubExpressionPart.ExpTypes.ConstantTypeName
                );
            SubExpressionPart singletonCode2 = new SubExpressionPart(
                "Singleton",
                SubExpressionPart.ExpTypes.Variable
                );
            SubExpressionPart singletonCode3 = new SubExpressionPart(
                "Code",
                SubExpressionPart.ExpTypes.Variable
                );
            SubExpressionPart singletonCode4 = new SubExpressionPart(
                "Length",
                SubExpressionPart.ExpTypes.Variable
                );
            mainformSingletonCode.Parts = new List<SubExpressionPart>() {
                singletonCode1,
                singletonCode2,
                singletonCode3,
            };
            mainformSingletonCodeCount.Parts = new List<SubExpressionPart>() {
                singletonCode1,
                singletonCode2,
                singletonCode3,
                singletonCode4
            };
            #endregion

            #region Block if
            // Premier block du if
            // if(MainForm.Singleton.Code == "hello")
            //     MainForm.Singleton.Code = MainForm.Singleton.Code + " World !" 
            // -------------------------------
            // ---> Condition
            // MainForm.Singleton.Code == "hello"
            ExpressionGroup ifCond1 = new ExpressionGroup(mainformSingletonCode,
                Operators.Equals, new Mutable("hello"));

            // ---> Block
            // MainForm.Singleton.Code = MainForm.Singleton.Code + " World !" 
            AffectationInstruction affect1 = new AffectationInstruction();
            affect1.LeftMember = mainformSingletonCode;
            affect1.RightMember = new ExpressionGroup(mainformSingletonCode,
                Operators.Plus, new Mutable(" World !"));

            // ---> fin
            _if1.Condition = ifCond1;
            _if1.Block.Instructions = new List<Instruction>() { affect1 };
            #endregion

            #region Block elsif
            // Second block du if
            // else if (MainForm.Singleton.Code.Count - 50 < 0)
            // {
            //     int c = 0.89;
            //     while(MainForm.Singleton.Code.Count < 500)
            //     {
            //         c = (c+0.1)*c;
            //         dum.DummyMethod(c);
            //     }       
            //     dum.DummyMethod(Dummy.TypeOf("string"));
            // }
            // ----------------------------------
            // ----> Condition
            ExpressionGroup elsifCond = new ExpressionGroup(
                new ExpressionGroup(mainformSingletonCodeCount, Operators.Minus, new Mutable(50)),
                Operators.SmallerThan,
                new Mutable(0));

            // ----> Block
            // int c = 3
            AffectationInstruction affect2 = new AffectationInstruction();
            SubExpression c = new SubExpression(
                new SubExpressionPart("c", SubExpressionPart.ExpTypes.Variable));
            affect2.LeftMember = c;
            affect2.RightMember = new Mutable(0.89);

            // le while
            WhileStatement whileStatement = CreateWhileBlock(globalContext, mainformSingletonCodeCount);

            // dum.DummyMethod(Dummy.TypeOf("string"))
            MethodCallInstruction call2 = new MethodCallInstruction(
                new SubExpression(
                    new SubExpressionPart("dum", SubExpressionPart.ExpTypes.Variable),
                    new SubExpressionPart("DummyMethod",
                        SubExpressionPart.ExpTypes.Method,
                        new List<IGettable>()
                        {
                            new SubExpression(
                                new SubExpressionPart("Dummy", SubExpressionPart.ExpTypes.ConstantTypeName),
                                new SubExpressionPart("TypeOf", SubExpressionPart.ExpTypes.Method,
                                    new List<IGettable>()
                                    {
                                        new Mutable("string")
                                    }
                                )
                            )
                        }
                    )
                )
            );

            // ---> fin
            _if2.Condition = elsifCond;
            _if2.Block.Instructions = new List<Instruction>()
            {
                affect2,
                whileStatement,
                call2
            };
            Dummy.debugElsifIn = _if2.Block.Context;
            #endregion

            #region Block else
            // Block _else
            // else
            //    dum.DummyMethod("shit");
            // -------------------------------
            MethodCallInstruction last = new MethodCallInstruction(
                new SubExpression(
                    new SubExpressionPart("dum", SubExpressionPart.ExpTypes.Variable),
                    new SubExpressionPart("DummyMethod", SubExpressionPart.ExpTypes.Method,
                        new List<IGettable>()
                        {
                            new Mutable("shit")
                        }
                    )
                )
            );
            _else.Instructions = new List<Instruction>() { last };
            #endregion

            // Finalisation
            mainBlock.Instructions = new List<Instruction>() { affectDum, _if };

            var action = mainBlock.Execute(null);
        }
        WhileStatement CreateWhileBlock(GlobalContext c, SubExpression count)
        {
            //     while(MainForm.Singleton.Code.Count < 500)
            //     {
            //         c = (c+0.1)*c;
            //         dum.DummyMethod(c);
            //     }       
            WhileStatement statement = new WhileStatement();
            // ---> Condition
            ExpressionGroup condition = new ExpressionGroup(
                count,
                Operators.SmallerThan,
                new Mutable(500));

            // ---> Affectation 
            AffectationInstruction affect = new AffectationInstruction();
            affect.LeftMember = SubExpression.Variable("c");
            affect.RightMember = new ExpressionGroup(
                SubExpression.Variable("c"),
                Operators.Mult,
                new ExpressionGroup(
                    SubExpression.Variable("c"),
                    Operators.Plus,
                    new Mutable(0.1)));

            // ---> Appel méthode
            // dum.DummyMethod(c)
            MethodCallInstruction call1 = new MethodCallInstruction(
                new SubExpression(
                    new SubExpressionPart("dum", SubExpressionPart.ExpTypes.Variable),
                    new SubExpressionPart("DummyMethod",
                        SubExpressionPart.ExpTypes.Method,
                        new List<IGettable>() { SubExpression.Variable("c") })
                    ));

            // ---> fin
            statement.Block = new Block(c);
            statement.Block.Instructions = new List<Instruction>() { affect, call1 };
            statement.Condition = condition;
            Dummy.debugWhileIn = statement.Block.Context;
            return statement;

        }
        #endregion

        #region Testing elements
        public int var1 = 3;
        public static int varS = 5;
        public int Method(int a)
        {
            return a + 5;
        }
        public static int SMethod(int a)
        {
            return a + 2;
        }

        #endregion
    }
    public class Dummy
    {
        public Dummy()
        {

        }
        public void DummyMethod(object o)
        {
            MainForm.Singleton.Code += o.ToString() + "\n";
        }
        public static PonyCarpetExtractor.ExpressionTree.Context context;
        public static PonyCarpetExtractor.ExpressionTree.Context debugWhileIn;
        public static PonyCarpetExtractor.ExpressionTree.Context debugElsifIn;
        public static Type TypeOf(string type)
        {
            throw new Exception();
        }
    }
}
