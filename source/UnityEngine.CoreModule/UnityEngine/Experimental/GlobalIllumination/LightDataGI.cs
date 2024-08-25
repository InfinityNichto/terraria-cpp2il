using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000135")]
	public struct LightDataGI
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D778", Offset = "0x1F8D778", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D7E0", Offset = "0x1F8D7E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref PointLight light, ref Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D850", Offset = "0x1F8D850", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref SpotLight light, ref Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D8C8", Offset = "0x1F8D8C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref RectangleLight light, ref Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D938", Offset = "0x1F8D938", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(ref DiscLight light, ref Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D9A8", Offset = "0x1F8D9A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void InitNoBake(int lightInstanceID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int instanceID;

		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int cookieID;

		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float cookieScale;

		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public LinearColor color;

		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public LinearColor indirectColor;

		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Quaternion orientation;

		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Vector3 position;

		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float range;

		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float coneAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float innerConeAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float shape0;

		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float shape1;

		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public LightType type;

		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D")]
		public LightMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E")]
		public byte shadow;

		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F")]
		public FalloffType falloff;
	}
}
