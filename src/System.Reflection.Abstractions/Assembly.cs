using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Reflection.Abstractions
{
    public class Assembly : IAssembly
    {
        public string CreateQualifiedName(string assemblyName, string typeName)
            => Reflection.Assembly.CreateQualifiedName(assemblyName, typeName);

        public Reflection.Assembly GetAssembly(Type type)
            => Reflection.Assembly.GetAssembly(type);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly GetCallingAssembly()
            => Reflection.Assembly.GetCallingAssembly();

        public Reflection.Assembly GetEntryAssembly()
            => Reflection.Assembly.GetEntryAssembly();

        public Reflection.Assembly GetExecutingAssembly()
            => Reflection.Assembly.GetExecutingAssembly();

        public Reflection.Assembly Load(string assemblyString)
            => Reflection.Assembly.Load(assemblyString);

        public Reflection.Assembly Load(AssemblyName assemblyRef)
            => Reflection.Assembly.Load(assemblyRef);

        public Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
            => Reflection.Assembly.Load(rawAssembly, rawSymbolStore);

        public Reflection.Assembly Load(byte[] rawAssembly)
            => Reflection.Assembly.Load(rawAssembly);

        public Reflection.Assembly LoadFile(string path)
            => Reflection.Assembly.LoadFile(path);

        public Reflection.Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
            => Reflection.Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm);

        public Reflection.Assembly LoadFrom(string assemblyFile)
            => Reflection.Assembly.LoadFrom(assemblyFile);

        [Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Reflection.Assembly LoadWithPartialName(string partialName)
            => Reflection.Assembly.LoadWithPartialName(partialName);

        public Reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly)
            => Reflection.Assembly.ReflectionOnlyLoad(rawAssembly);

        public Reflection.Assembly ReflectionOnlyLoad(string assemblyString)
            => Reflection.Assembly.ReflectionOnlyLoad(assemblyString);

        public Reflection.Assembly ReflectionOnlyLoadFrom(string assemblyFile)
            => Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFile);

        public Reflection.Assembly UnsafeLoadFrom(string assemblyFile)
            => Reflection.Assembly.UnsafeLoadFrom(assemblyFile);
    }
}
