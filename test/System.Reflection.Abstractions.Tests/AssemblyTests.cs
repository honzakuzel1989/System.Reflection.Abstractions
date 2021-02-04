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
    }
}
