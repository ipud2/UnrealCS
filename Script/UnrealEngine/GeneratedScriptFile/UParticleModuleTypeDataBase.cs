using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UParticleModuleTypeDataBase:UParticleModule 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
