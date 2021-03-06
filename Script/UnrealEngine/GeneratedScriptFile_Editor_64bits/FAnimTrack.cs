#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This is list of anim segments for this track
	/// For now this is only one TArray, but in the future
	/// we should define more transition/blending behaviors
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FAnimTrack
	{
		public TStructArray<FAnimSegment> AnimSegments
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimSegment>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
