using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System.Reflection.Abstractions
{
    public class Assembly : IAssembly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string CreateQualifiedName(string assemblyName, string typeName)
            => Reflection.Assembly.CreateQualifiedName(assemblyName, typeName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly GetAssembly(Type type)
            => Reflection.Assembly.GetAssembly(type);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly GetCallingAssembly()
            => Reflection.Assembly.GetCallingAssembly();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly GetEntryAssembly()
            => Reflection.Assembly.GetEntryAssembly();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Reflection.Assembly GetExecutingAssembly()
            // We have to change ExecutingAssembly to CallingAssembly because the ExecutingAssembly
            // is in this context the CallingAssembly.. But can't be inline!
            => Reflection.Assembly.GetCallingAssembly();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly Load(string assemblyString)
            => Reflection.Assembly.Load(assemblyString);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly Load(AssemblyName assemblyRef)
            => Reflection.Assembly.Load(assemblyRef);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
            => Reflection.Assembly.Load(rawAssembly, rawSymbolStore);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly Load(byte[] rawAssembly)
            => Reflection.Assembly.Load(rawAssembly);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly LoadFile(string path)
            => Reflection.Assembly.LoadFile(path);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
            => Reflection.Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly LoadFrom(string assemblyFile)
            => Reflection.Assembly.LoadFrom(assemblyFile);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Reflection.Assembly LoadWithPartialName(string partialName)
            => Reflection.Assembly.LoadWithPartialName(partialName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly)
            => Reflection.Assembly.ReflectionOnlyLoad(rawAssembly);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly ReflectionOnlyLoad(string assemblyString)
            => Reflection.Assembly.ReflectionOnlyLoad(assemblyString);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly ReflectionOnlyLoadFrom(string assemblyFile)
            => Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFile);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Reflection.Assembly UnsafeLoadFrom(string assemblyFile)
            => Reflection.Assembly.UnsafeLoadFrom(assemblyFile);
    }
}
