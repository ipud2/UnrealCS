#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UReflectionCaptureComponent
	{
		static readonly int CaptureOffsetComponent__Offset;
		public UBillboardComponent CaptureOffsetComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CaptureOffsetComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Cubemap__Offset;
		public UTextureCube Cubemap
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Cubemap__Offset); if (v == IntPtr.Zero)return null; UTextureCube retValue = new UTextureCube(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Cubemap__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Cubemap__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceCubemapAngle__Offset;
		public float SourceCubemapAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SourceCubemapAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceCubemapAngle__Offset, false);}
			
		}
		
		static readonly int Brightness__Offset;
		public float Brightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Brightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Brightness__Offset, false);}
			
		}
		
		static readonly int CaptureOffset__Offset;
		public FVector CaptureOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+CaptureOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CaptureOffset__Offset, false);}
			
		}
		
		static readonly int StateId__Offset;
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static UReflectionCaptureComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ReflectionCaptureComponent");
			CaptureOffsetComponent__Offset=GetPropertyOffset(NativeClassPtr,"CaptureOffsetComponent");
			Cubemap__Offset=GetPropertyOffset(NativeClassPtr,"Cubemap");
			SourceCubemapAngle__Offset=GetPropertyOffset(NativeClassPtr,"SourceCubemapAngle");
			Brightness__Offset=GetPropertyOffset(NativeClassPtr,"Brightness");
			CaptureOffset__Offset=GetPropertyOffset(NativeClassPtr,"CaptureOffset");
			StateId__Offset=GetPropertyOffset(NativeClassPtr,"StateId");
			
		}
		
	}
	
}
#endif
#endif
