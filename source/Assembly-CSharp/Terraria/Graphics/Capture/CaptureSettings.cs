using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture
{
	// Token: 0x02000508 RID: 1288
	[global::Cpp2ILInjected.Token(Token = "0x200076E")]
	public class CaptureSettings
	{
		// Token: 0x060037CA RID: 14282 RVA: 0x0002BF85 File Offset: 0x0002A185
		[global::Cpp2ILInjected.Token(Token = "0x6003E66")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B05A0", Offset = "0x14B05A0", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "UpdateButtons", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "QuickScreenshot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureManager), Member = "Capture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public CaptureSettings()
		{
			throw null;
		}

		// Token: 0x040067FE RID: 26622
		[global::Cpp2ILInjected.Token(Token = "0x4007D19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Rectangle Area;

		// Token: 0x040067FF RID: 26623
		[global::Cpp2ILInjected.Token(Token = "0x4007D1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool UseScaling;

		// Token: 0x04006800 RID: 26624
		[global::Cpp2ILInjected.Token(Token = "0x4007D1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string OutputName;

		// Token: 0x04006801 RID: 26625
		[global::Cpp2ILInjected.Token(Token = "0x4007D1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool CaptureEntities;

		// Token: 0x04006802 RID: 26626
		[global::Cpp2ILInjected.Token(Token = "0x4007D1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public CaptureBiome Biome;

		// Token: 0x04006803 RID: 26627
		[global::Cpp2ILInjected.Token(Token = "0x4007D1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool CaptureMech;

		// Token: 0x04006804 RID: 26628
		[global::Cpp2ILInjected.Token(Token = "0x4007D1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool CaptureBackground;
	}
}
