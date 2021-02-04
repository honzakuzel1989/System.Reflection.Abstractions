using System.Configuration.Assemblies;

namespace System.Reflection.Abstractions
{
    public interface IAssembly
    {
        //
        // Summary:
        //     Creates the name of a type qualified by the display name of its assembly.
        //
        // Parameters:
        //   assemblyName:
        //     The display name of an assembly.
        //
        //   typeName:
        //     The full name of a type.
        //
        // Returns:
        //     The full name of the type qualified by the display name of the assembly.
        string CreateQualifiedName(string assemblyName, string typeName);
        //
        // Summary:
        //     Gets the currently loaded assembly in which the specified type is defined.
        //
        // Parameters:
        //   type:
        //     An object representing a type in the assembly that will be returned.
        //
        // Returns:
        //     The assembly in which the specified type is defined.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Reflection.Assembly GetAssembly(Type type);
        //
        // Summary:
        //     Returns the System.Reflection.Assembly of the method that invoked the currently
        //     executing method.
        //
        // Returns:
        //     The Assembly object of the method that invoked the currently executing method.
        Reflection.Assembly GetCallingAssembly();
        //
        // Summary:
        //     Gets the process executable in the default application domain. In other application
        //     domains, this is the first executable that was executed by System.AppDomain.ExecuteAssembly(System.String).
        //
        // Returns:
        //     The assembly that is the process executable in the default application domain,
        //     or the first executable that was executed by System.AppDomain.ExecuteAssembly(System.String).
        //     Can return null when called from unmanaged code.
        Reflection.Assembly GetEntryAssembly();
        //
        // Summary:
        //     Gets the assembly that contains the code that is currently executing.
        //
        // Returns:
        //     The assembly that contains the code that is currently executing.
        Reflection.Assembly GetExecutingAssembly();
        //
        // Summary:
        //     Loads an assembly given the long form of its name.
        //
        // Parameters:
        //   assemblyString:
        //     The long form of the assembly name.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyString is null.
        //
        //   T:System.ArgumentException:
        //     assemblyString is a zero-length string.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyString is not found.
        //
        //   T:System.IO.FileLoadException:
        //     A file that was found could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyString is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and assemblyString was compiled with a later
        //     version.
        Reflection.Assembly Load(string assemblyString);
        //
        // Summary:
        //     Loads an assembly given its System.Reflection.AssemblyName.
        //
        // Parameters:
        //   assemblyRef:
        //     The object that describes the assembly to be loaded.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyRef is null.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyRef is not found.
        //
        //   T:System.IO.FileLoadException:
        //     In the [.NET for Windows Store apps](http://go.microsoft.com/fwlink/?LinkID=247912)
        //     or the [Portable Class Library](~/docs/standard/cross-platform/cross-platform-development-with-the-portable-class-library.md),
        //     catch the base class exception, System.IO.IOException, instead. A file that was
        //     found could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyRef is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and assemblyRef was compiled with a later
        //     version.
        Reflection.Assembly Load(AssemblyName assemblyRef);
        //
        // Summary:
        //     Loads the assembly with a common object file format (COFF)-based image containing
        //     an emitted assembly, optionally including symbols for the assembly. The assembly
        //     is loaded into the application domain of the caller.
        //
        // Parameters:
        //   rawAssembly:
        //     A byte array that is a COFF-based image containing an emitted assembly.
        //
        //   rawSymbolStore:
        //     A byte array that contains the raw bytes representing the symbols for the assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     rawAssembly is null.
        //
        //   T:System.BadImageFormatException:
        //     rawAssembly is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and rawAssembly was compiled with a later
        //     version.
        Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
        //
        // Summary:
        //     Loads the assembly with a common object file format (COFF)-based image containing
        //     an emitted assembly. The assembly is loaded into the application domain of the
        //     caller.
        //
        // Parameters:
        //   rawAssembly:
        //     A byte array that is a COFF-based image containing an emitted assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     rawAssembly is null.
        //
        //   T:System.BadImageFormatException:
        //     rawAssembly is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and rawAssembly was compiled with a later
        //     version.
        Reflection.Assembly Load(byte[] rawAssembly);
        //
        // Summary:
        //     Loads the contents of an assembly file on the specified path.
        //
        // Parameters:
        //   path:
        //     The fully qualified path of the file to load.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The path argument is not an absolute path.
        //
        //   T:System.ArgumentNullException:
        //     The path parameter is null.
        //
        //   T:System.IO.FileLoadException:
        //     A file that was found could not be loaded.
        //
        //   T:System.IO.FileNotFoundException:
        //     The path parameter is an empty string ("") or does not exist.
        //
        //   T:System.BadImageFormatException:
        //     path is not a valid assembly. -or- Version 2.0 or later of the common language
        //     runtime is currently loaded and path was compiled with a later version.
        Reflection.Assembly LoadFile(string path);
        //
        // Summary:
        //     Loads an assembly given its file name or path, hash value, and hash algorithm.
        //
        // Parameters:
        //   assemblyFile:
        //     The name or path of the file that contains the manifest of the assembly.
        //
        //   hashValue:
        //     The value of the computed hash code.
        //
        //   hashAlgorithm:
        //     The hash algorithm used for hashing files and for generating the strong name.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyFile is null.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyFile is not found, or the module you are trying to load does not specify
        //     a file name extension.
        //
        //   T:System.IO.FileLoadException:
        //     A file that was found could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyFile is not a valid assembly; for example, a 32-bit assembly in a 64-bit
        //     process. See the exception topic for more information. -or- assemblyFile was
        //     compiled with a later version of the common language runtime than the version
        //     that is currently loaded.
        //
        //   T:System.Security.SecurityException:
        //     A codebase that does not start with "file://" was specified without the required
        //     System.Net.WebPermission.
        //
        //   T:System.ArgumentException:
        //     The assemblyFile parameter is an empty string ("").
        //
        //   T:System.IO.PathTooLongException:
        //     The assembly name is longer than MAX_PATH characters.
        Reflection.Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
        //
        // Summary:
        //     Loads an assembly given its file name or path.
        //
        // Parameters:
        //   assemblyFile:
        //     The name or path of the file that contains the manifest of the assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyFile is null.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyFile is not found, or the module you are trying to load does not specify
        //     a filename extension.
        //
        //   T:System.IO.FileLoadException:
        //     A file that was found could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyFile is not a valid assembly; for example, a 32-bit assembly in a 64-bit
        //     process. See the exception topic for more information. -or- Version 2.0 or later
        //     of the common language runtime is currently loaded and assemblyFile was compiled
        //     with a later version.
        //
        //   T:System.Security.SecurityException:
        //     A codebase that does not start with "file://" was specified without the required
        //     System.Net.WebPermission.
        //
        //   T:System.ArgumentException:
        //     The assemblyFile parameter is an empty string ("").
        //
        //   T:System.IO.PathTooLongException:
        //     The assembly name is longer than MAX_PATH characters.
        Reflection.Assembly LoadFrom(string assemblyFile);
        //
        // Summary:
        //     Loads an assembly from the application directory or from the global assembly
        //     cache using a partial name.
        //
        // Parameters:
        //   partialName:
        //     The display name of the assembly.
        //
        // Returns:
        //     The loaded assembly. If partialName is not found, this method returns null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The partialName parameter is null.
        //
        //   T:System.BadImageFormatException:
        //     assemblyFile is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and partialName was compiled with a later
        //     version.
        [Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        Reflection.Assembly LoadWithPartialName(string partialName);
        //
        // Summary:
        //     Loads the assembly from a common object file format (COFF)-based image containing
        //     an emitted assembly. The assembly is loaded into the reflection-only context
        //     of the caller's application domain.
        //
        // Parameters:
        //   rawAssembly:
        //     A byte array that is a COFF-based image containing an emitted assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     rawAssembly is null.
        //
        //   T:System.BadImageFormatException:
        //     rawAssembly is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and rawAssembly was compiled with a later
        //     version.
        //
        //   T:System.IO.FileLoadException:
        //     rawAssembly cannot be loaded.
        Reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly);
        //
        // Summary:
        //     Loads an assembly into the reflection-only context, given its display name.
        //
        // Parameters:
        //   assemblyString:
        //     The display name of the assembly, as returned by the System.Reflection.AssemblyName.FullName
        //     property.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyString is null.
        //
        //   T:System.ArgumentException:
        //     assemblyString is an empty string ("").
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyString is not found.
        //
        //   T:System.IO.FileLoadException:
        //     assemblyString is found, but cannot be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyString is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and assemblyString was compiled with a later
        //     version.
        Reflection.Assembly ReflectionOnlyLoad(string assemblyString);
        //
        // Summary:
        //     Loads an assembly into the reflection-only context, given its path.
        //
        // Parameters:
        //   assemblyFile:
        //     The path of the file that contains the manifest of the assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyFile is null.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyFile is not found, or the module you are trying to load does not specify
        //     a file name extension.
        //
        //   T:System.IO.FileLoadException:
        //     assemblyFile is found, but could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyFile is not a valid assembly. -or- Version 2.0 or later of the common
        //     language runtime is currently loaded and assemblyFile was compiled with a later
        //     version.
        //
        //   T:System.Security.SecurityException:
        //     A codebase that does not start with "file://" was specified without the required
        //     System.Net.WebPermission.
        //
        //   T:System.IO.PathTooLongException:
        //     The assembly name is longer than MAX_PATH characters.
        //
        //   T:System.ArgumentException:
        //     assemblyFile is an empty string ("").
        Reflection.Assembly ReflectionOnlyLoadFrom(string assemblyFile);
        //
        // Summary:
        //     Loads an assembly into the load-from context, bypassing some security checks.
        //
        // Parameters:
        //   assemblyFile:
        //     The name or path of the file that contains the manifest of the assembly.
        //
        // Returns:
        //     The loaded assembly.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     assemblyFile is null.
        //
        //   T:System.IO.FileNotFoundException:
        //     assemblyFile is not found, or the module you are trying to load does not specify
        //     a filename extension.
        //
        //   T:System.IO.FileLoadException:
        //     A file that was found could not be loaded.
        //
        //   T:System.BadImageFormatException:
        //     assemblyFile is not a valid assembly. -or- assemblyFile was compiled with a later
        //     version of the common language runtime than the version that is currently loaded.
        //
        //   T:System.Security.SecurityException:
        //     A codebase that does not start with "file://" was specified without the required
        //     System.Net.WebPermission.
        //
        //   T:System.ArgumentException:
        //     The assemblyFile parameter is an empty string ("").
        //
        //   T:System.IO.PathTooLongException:
        //     The assembly name is longer than MAX_PATH characters.
        Reflection.Assembly UnsafeLoadFrom(string assemblyFile);
    }
}
