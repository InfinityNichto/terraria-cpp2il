using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.GlobalIllumination;

namespace UnityEngine
{
	// Token: 0x02000041 RID: 65
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Light.h")]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	[RequireComponent(typeof(Transform))]
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public sealed class Light : Behaviour
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public extern LightShadows shadows
		{
			[NativeMethod("GetShadowType")]
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CE20", Offset = "0x1F6CE20", Length = "0x3C")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008B RID: 139
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public extern float cookieSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CE5C", Offset = "0x1F6CE5C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref Cookie)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public extern Texture cookie
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000094")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CE98", Offset = "0x1F6CE98", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref Cookie)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008D RID: 141
		[NativeProperty("LightType")]
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public extern LightType type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CED4", Offset = "0x1F6CED4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref Cookie)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
			{
				typeof(Light[]),
				typeof(NativeArray<LightDataGI>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public extern float spotAngle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CF10", Offset = "0x1F6CF10", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractInnerCone", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref SpotLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000217F File Offset: 0x0000037F
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public Color color
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CF4C", Offset = "0x1F6CF4C", Length = "0x58")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public extern float colorTemperature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CFE8", Offset = "0x1F6CFE8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public extern bool useColorTemperature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000099")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D024", Offset = "0x1F6D024", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public extern float intensity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D060", Offset = "0x1F6D060", Length = "0x3C")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public extern float bounceIntensity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D09C", Offset = "0x1F6D09C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(LinearColor))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public extern float range
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D0D8", Offset = "0x1F6D0D8", Length = "0x3C")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002182 File Offset: 0x00000382
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public LightBakingOutput bakingOutput
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D114", Offset = "0x1F6D114", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6CFA4", Offset = "0x1F6CFA4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x06000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D17C", Offset = "0x1F6D17C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_bakingOutput_Injected(out LightBakingOutput ret);

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_BakedIndex;
	}
}
