using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000112 RID: 274
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000135")]
	public struct LightDataGI
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00002D10 File Offset: 0x00000F10
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D778", Offset = "0x1F8D778", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			throw null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002D13 File Offset: 0x00000F13
		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D7E0", Offset = "0x1F8D7E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref PointLight light, ref Cookie cookie)
		{
			throw null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002D16 File Offset: 0x00000F16
		[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D850", Offset = "0x1F8D850", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref SpotLight light, ref Cookie cookie)
		{
			throw null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002D19 File Offset: 0x00000F19
		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D8C8", Offset = "0x1F8D8C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref RectangleLight light, ref Cookie cookie)
		{
			throw null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002D1C File Offset: 0x00000F1C
		[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D938", Offset = "0x1F8D938", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref DiscLight light, ref Cookie cookie)
		{
			throw null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002D1F File Offset: 0x00000F1F
		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D9A8", Offset = "0x1F8D9A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void InitNoBake(int lightInstanceID)
		{
			throw null;
		}

		// Token: 0x040004FD RID: 1277
		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x040004FE RID: 1278
		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int cookieID;

		// Token: 0x040004FF RID: 1279
		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float cookieScale;

		// Token: 0x04000500 RID: 1280
		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public LinearColor color;

		// Token: 0x04000501 RID: 1281
		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public LinearColor indirectColor;

		// Token: 0x04000502 RID: 1282
		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Quaternion orientation;

		// Token: 0x04000503 RID: 1283
		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Vector3 position;

		// Token: 0x04000504 RID: 1284
		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float range;

		// Token: 0x04000505 RID: 1285
		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float coneAngle;

		// Token: 0x04000506 RID: 1286
		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float innerConeAngle;

		// Token: 0x04000507 RID: 1287
		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float shape0;

		// Token: 0x04000508 RID: 1288
		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float shape1;

		// Token: 0x04000509 RID: 1289
		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public LightType type;

		// Token: 0x0400050A RID: 1290
		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D")]
		public LightMode mode;

		// Token: 0x0400050B RID: 1291
		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E")]
		public byte shadow;

		// Token: 0x0400050C RID: 1292
		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F")]
		public FalloffType falloff;
	}
}
