#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionLinearInterpolate
	{
		static readonly int A__Offset;
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int B__Offset;
		public FExpressionInput B
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+B__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Alpha__Offset;
		public FExpressionInput Alpha
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Alpha__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ConstA__Offset;
		public float ConstA
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstA__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstA__Offset, false);}
			
		}
		
		static readonly int ConstB__Offset;
		public float ConstB
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstB__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstB__Offset, false);}
			
		}
		
		static readonly int ConstAlpha__Offset;
		public float ConstAlpha
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstAlpha__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstAlpha__Offset, false);}
			
		}
		
		static UMaterialExpressionLinearInterpolate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionLinearInterpolate");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			Alpha__Offset=GetPropertyOffset(NativeClassPtr,"Alpha");
			ConstA__Offset=GetPropertyOffset(NativeClassPtr,"ConstA");
			ConstB__Offset=GetPropertyOffset(NativeClassPtr,"ConstB");
			ConstAlpha__Offset=GetPropertyOffset(NativeClassPtr,"ConstAlpha");
			
		}
		
	}
	
}
#endif
#endif
