using EvalTransaccionNova;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Novasoft.Client.ViewModels
{
    
    public class DocumentosViewModel :IDocumentosViewModel
    {
        public void pruebaNuguet()
        {
            var obj = new EvalTransaccionNova.EvalTransaction();
            var a=obj.EvalTransaccion("GenerarExcepcion(prueba, prueba)","prueba");

        }
        public void EjecutarMetodoDinamico(string codigoMetodo)
        {
            string codigoFuente = $"public static void MetodoDinamico(string mensaje) {{ throw new Exception(mensaje); }}";
            CSharpCodeProvider proveedor = new();
            CompilerParameters parametros = new();
            parametros.GenerateExecutable = false;
            parametros.GenerateInMemory = true;

            CompilerResults resultados = proveedor.CompileAssemblyFromSource(parametros, codigoFuente);

            if (resultados.Errors.HasErrors)
            {
                // Manejo de errores de compilación
                foreach (CompilerError error in resultados.Errors)
                {
                    Console.WriteLine(error.ErrorText);
                }
            }
            else
            {
                // Ejecuta el método dinámico
                Type tipo = resultados.CompiledAssembly.GetType("<GeneratedClassName>");
                if (tipo != null)
                {
                    object instancia = Activator.CreateInstance(tipo);
                    tipo.InvokeMember($"MetodoDinamico({codigoMetodo})", BindingFlags.InvokeMethod, null, instancia, null);
                }
            }

        }
    }
    public interface IDocumentosViewModel
    {
        void EjecutarMetodoDinamico(string codigoMetodo);
        void pruebaNuguet();
    }
}




