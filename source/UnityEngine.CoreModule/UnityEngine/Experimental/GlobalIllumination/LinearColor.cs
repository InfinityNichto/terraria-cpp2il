using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200010B RID: 267
	[global::Cpp2ILInjected.Token(Token = "0x200012E")]
	public struct LinearColor
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00002CF8 File Offset: 0x00000EF8
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00002CFB File Offset: 0x00000EFB
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		public float red
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D204", Offset = "0x1F8D204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D20C", Offset = "0x1F8D20C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(ref LinearColor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00002CFE File Offset: 0x00000EFE
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00002D01 File Offset: 0x00000F01
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public float green
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D2B8", Offset = "0x1F8D2B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D2C0", Offset = "0x1F8D2C0", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(ref LinearColor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00002D04 File Offset: 0x00000F04
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00002D07 File Offset: 0x00000F07
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public float blue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D36C", Offset = "0x1F8D36C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D374", Offset = "0x1F8D374", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ApplyColorTemperature", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(ref LinearColor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002D0A File Offset: 0x00000F0A
		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D420", Offset = "0x1F8D420", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DirectionalLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref PointLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref RectangleLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DiscLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static LinearColor Convert(Color color, float intensity)
		{
			throw null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002D0D File Offset: 0x00000F0D
		[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D764", Offset = "0x1F8D764", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static LinearColor Black()
		{
			throw null;
		}

		// Token: 0x040004C1 RID: 1217
		[global::Cpp2ILInjected.Token(Token = "0x400050F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float m_red;

		// Token: 0x040004C2 RID: 1218
		[global::Cpp2ILInjected.Token(Token = "0x4000510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float m_green;

		// Token: 0x040004C3 RID: 1219
		[global::Cpp2ILInjected.Token(Token = "0x4000511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float m_blue;

		// Token: 0x040004C4 RID: 1220
		[global::Cpp2ILInjected.Token(Token = "0x4000512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_intensity;
	}
}
