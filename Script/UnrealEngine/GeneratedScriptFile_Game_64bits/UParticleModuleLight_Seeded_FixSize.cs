#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLight_Seeded
	{
		static readonly int RandomSeedInfo__Offset;
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get{ CheckIsValid();return (FParticleRandomSeedInfo)Marshal.PtrToStructure(_this.Get()+RandomSeedInfo__Offset, typeof(FParticleRandomSeedInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomSeedInfo__Offset, false);}
			
		}
		
		static UParticleModuleLight_Seeded()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLight_Seeded");
			RandomSeedInfo__Offset=GetPropertyOffset(NativeClassPtr,"RandomSeedInfo");
			
		}
		
	}
	
}
#endif
#endif
