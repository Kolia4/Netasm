using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Netasm.Statements;

namespace Netasm
{
    public class Compiler
    {
        private readonly Application instance;
        private readonly Statements.Application application;

        public Compiler(Application instance)
        {
            this.instance = instance;
            this.application = Parse();
        }

        private Statements.Application Parse()
        {
            var type = instance.GetType();
            var application = new Statements.Application(type.Name);

            var fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var fieldInfo in fieldInfos)
            {
                application.fields.Add(new Field(fieldInfo.Name, (BaseType)fieldInfo.GetValue(instance)));
            }

            var methodInfos = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var methodInfo in methodInfos)
            {
                instance.currentMethod = new Statements.Method(methodInfo.Name);
                methodInfo.Invoke(instance, null);
                application.methods.Add(instance.currentMethod);
            }
            return application;
        }
    }
}
