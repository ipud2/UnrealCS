#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Subsurface Scattering profile asset, can be specified at the material. Only for "Subsurface Profile" materials, is use during Screenspace Subsurface Scattering
	/// Don't change at runtime. All properties in here are per material - texture like variations need to come from properties that are in the GBuffer.
	/// </summary>
	public partial class USubsurfaceProfile
	{
		static readonly int Settings__Offset;
		public FSubsurfaceProfileStruct Settings
		{
			get{ CheckIsValid();return (FSubsurfaceProfileStruct)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FSubsurfaceProfileStruct));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Settings__Offset, false);}
			
		}
		
		static USubsurfaceProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubsurfaceProfile");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			
		}
		
	}
	
}
#endif
#endif
