#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=124)]
	public partial struct FMovieSceneGenerationLedger
	{
		[FieldOffset(0)]
		public FMovieSceneTrackIdentifier LastTrackIdentifier;
		
	}
	
}
#endif
#endif
