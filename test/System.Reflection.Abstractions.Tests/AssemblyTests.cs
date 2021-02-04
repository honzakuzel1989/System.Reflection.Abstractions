using System.IO;
using Xunit;

namespace System.Reflection.Abstractions.Tests
{
    using OriginalAssembly = Reflection.Assembly;
    using AbstractAssembly = Assembly;

    public class AssemblyTests
    {
        private readonly AbstractAssembly _assembly;

        public AssemblyTests()
        {
            _assembly = new AbstractAssembly();
        }


        [Theory]
        [InlineData("System.Runtime", "System.Reflection.Assembly")]
        public void CreateQualifiedName_ValidInput_MustReturnSameValueAsOriginal(string assemblyName, string typeName)
        {
            Assert.Equal(OriginalAssembly.CreateQualifiedName(assemblyName, typeName),
                _assembly.CreateQualifiedName(assemblyName, typeName));
        }

        [Theory]
        [InlineData(typeof(int))]
        public void GetAssembly_ValidInput_MustReturnSameValueAsOriginal(Type type)
        {
            Assert.Equal(OriginalAssembly.GetAssembly(type),
                _assembly.GetAssembly(type));
        }

        [Fact]
        public void GetCallingAssembly_ValidInput_MustReturnSameValueAsOriginal()
        {
            Assert.Equal(OriginalAssembly.GetCallingAssembly(),
                _assembly.GetCallingAssembly());
        }

        [Fact]
        public void GetEntryAssembly_ValidInput_MustReturnSameValueAsOriginal()
        {
            Assert.Equal(OriginalAssembly.GetEntryAssembly(),
                _assembly.GetEntryAssembly());
        }

        [Fact]
        public void GetExecutingAssembly_ValidInput_MustReturnSameValueAsOriginal()
        {
            Assert.Equal(OriginalAssembly.GetExecutingAssembly(),
                _assembly.GetExecutingAssembly());
        }

        [Fact]
        public void LoadByAssemblyRef_ValidInput_MustReturnSameValueAsOriginal()
        {
            AssemblyName assemblyRef = new AssemblyName("System.Runtime");

            Assert.Equal(OriginalAssembly.Load(assemblyRef),
                _assembly.Load(assemblyRef));
        }

        [Fact]
        public void LoadByRawAssembly_ValidInput_MustReturnSameValueAsOriginal()
        {
            byte[] rawAssembly = File.ReadAllBytes(OriginalAssembly.GetExecutingAssembly().Location);

            Assert.Equal(OriginalAssembly.Load(rawAssembly).ToString(),
                _assembly.Load(rawAssembly).ToString());
        }

        [Theory]
        [InlineData("System.Runtime")]
        public void LoadByAssemblyString_ValidInput_MustReturnSameValueAsOriginal(string assemblyString)
        {
            Assert.Equal(OriginalAssembly.Load(assemblyString),
                _assembly.Load(assemblyString));
        }

        [Fact]
        public void LoadByRawAssemblyAndSymbolStore_ValidInput_MustReturnSameValueAsOriginal()
        {
            byte[] rawAssembly = File.ReadAllBytes(OriginalAssembly.GetExecutingAssembly().Location);

            Assert.Equal(OriginalAssembly.Load(rawAssembly, null).ToString(),
                _assembly.Load(rawAssembly, null).ToString());
        }

        [Fact]
        public void LoadFile_ValidInput_MustReturnSameValueAsOriginal()
        {
            string path = OriginalAssembly.GetExecutingAssembly().Location;

            Assert.Equal(OriginalAssembly.LoadFile(path),
                _assembly.LoadFile(path));
        }

        [Fact]
        public void LoadFromByAssemblyFile_ValidInput_MustReturnSameValueAsOriginal()
        {
            string path = OriginalAssembly.GetExecutingAssembly().Location;

            Assert.Equal(OriginalAssembly.LoadFrom(path),
                _assembly.LoadFrom(path));
        }

        [Fact]
        public void LoadFromByAssemblyFileAndHashCode_ValidInput_MustThrowSameExceptionAsOriginal()
        {
            string path = OriginalAssembly.GetExecutingAssembly().Location;

            Assert.Throws<NotSupportedException>(() => OriginalAssembly.LoadFrom(path, null, Configuration.Assemblies.AssemblyHashAlgorithm.None));
            Assert.Throws<NotSupportedException>(() => _assembly.LoadFrom(path, null, Configuration.Assemblies.AssemblyHashAlgorithm.None));
        }

        [Theory]
        [InlineData("System")]
        public void LoadWithPartialName_ValidInput_MustReturnSameValueAsOriginal(string partialName)
        {
            Assert.Equal(OriginalAssembly.LoadWithPartialName(partialName),
                _assembly.LoadWithPartialName(partialName));
        }

        [Theory]
        [InlineData("System")]
        public void ReflectionOnlyLoadByAssemblyString_ValidInput_MustThrowSameExceptionAsOriginal(string assemblyString)
        {
            Assert.Throws<PlatformNotSupportedException>(() => OriginalAssembly.ReflectionOnlyLoad(assemblyString));
            Assert.Throws<PlatformNotSupportedException>(() => _assembly.ReflectionOnlyLoad(assemblyString));
        }

        [Fact]
        public void ReflectionOnlyLoadByRawAssembly_ValidInput_MustThrowSameExceptionAsOriginal()
        {
            byte[] rawAssembly = File.ReadAllBytes(OriginalAssembly.GetExecutingAssembly().Location);

            Assert.Throws<PlatformNotSupportedException>(() => OriginalAssembly.ReflectionOnlyLoad(rawAssembly));
            Assert.Throws<PlatformNotSupportedException>(() => _assembly.ReflectionOnlyLoad(rawAssembly));
        }

        [Fact]
        public void ReflectionOnlyLoadFrom_ValidInput_MustThrowSameExceptionAsOriginal()
        {
            var assemblyFile = OriginalAssembly.GetExecutingAssembly().Location;

            Assert.Throws<PlatformNotSupportedException>(() => OriginalAssembly.ReflectionOnlyLoadFrom(assemblyFile));
            Assert.Throws<PlatformNotSupportedException>(() => _assembly.ReflectionOnlyLoadFrom(assemblyFile));
        }

        [Fact]
        public void UnsafeLoadFrom_ValidInput_MustThrowSameExceptionAsOriginal()
        {
            var assemblyFile = OriginalAssembly.GetExecutingAssembly().Location;

            Assert.Equal(OriginalAssembly.UnsafeLoadFrom(assemblyFile),
                _assembly.UnsafeLoadFrom(assemblyFile));
        }
    }
}
