using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x02000510 RID: 1296
	[global::Cpp2ILInjected.Token(Token = "0x2000779")]
	public class LightMap
	{
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x0002C01E File Offset: 0x0002A21E
		// (set) Token: 0x06003808 RID: 14344 RVA: 0x0002C021 File Offset: 0x0002A221
		[global::Cpp2ILInjected.Token(Token = "0x17000799")]
		public int NonVisiblePadding
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE38", Offset = "0x73FE38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE40", Offset = "0x73FE40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x0002C024 File Offset: 0x0002A224
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x0002C027 File Offset: 0x0002A227
		[global::Cpp2ILInjected.Token(Token = "0x1700079A")]
		public int Width
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE48", Offset = "0x73FE48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE50", Offset = "0x73FE50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0002C02A File Offset: 0x0002A22A
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x0002C02D File Offset: 0x0002A22D
		[global::Cpp2ILInjected.Token(Token = "0x1700079B")]
		public int Height
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE58", Offset = "0x73FE58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE60", Offset = "0x73FE60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0002C030 File Offset: 0x0002A230
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x0002C033 File Offset: 0x0002A233
		[global::Cpp2ILInjected.Token(Token = "0x1700079C")]
		public float LightDecayThroughAir
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F0EC", Offset = "0x73F0EC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F044", Offset = "0x73F044", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x0002C036 File Offset: 0x0002A236
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x0002C039 File Offset: 0x0002A239
		[global::Cpp2ILInjected.Token(Token = "0x1700079D")]
		public float LightDecayThroughSolid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F0F8", Offset = "0x73F0F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F088", Offset = "0x73F088", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x0002C03C File Offset: 0x0002A23C
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x0002C03F File Offset: 0x0002A23F
		[global::Cpp2ILInjected.Token(Token = "0x1700079E")]
		public Vector3 LightDecayThroughWater
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE68", Offset = "0x73FE68", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F0DC", Offset = "0x73F0DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x0002C042 File Offset: 0x0002A242
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x0002C045 File Offset: 0x0002A245
		[global::Cpp2ILInjected.Token(Token = "0x1700079F")]
		public Vector3 LightDecayThroughHoney
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE78", Offset = "0x73FE78", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x73F0CC", Offset = "0x73F0CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "UpdateLightDecay", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000705 RID: 1797
		[global::Cpp2ILInjected.Token(Token = "0x170007A0")]
		public Vector3 this[int x, int y]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x73E0F4", Offset = "0x73E0F4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003EB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x73FE94", Offset = "0x73FE94", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0002C04E File Offset: 0x0002A24E
		[global::Cpp2ILInjected.Token(Token = "0x6003EB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DC30", Offset = "0x73DC30", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = ".ctor", MemberParameters = new object[] { typeof(Camera) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "CreateWithRandomSeed", ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public LightMap()
		{
			throw null;
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0002C051 File Offset: 0x0002A251
		[global::Cpp2ILInjected.Token(Token = "0x6003EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEB4", Offset = "0x73FEB4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void GetLight(int x, int y, out Vector3 color)
		{
			throw null;
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0002C054 File Offset: 0x0002A254
		[global::Cpp2ILInjected.Token(Token = "0x6003EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEDC", Offset = "0x73FEDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LightMaskMode GetMask(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x0002C057 File Offset: 0x0002A257
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x73DFB8", Offset = "0x73DFB8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "PreRenderPhase", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x0002C05A File Offset: 0x0002A25A
		[global::Cpp2ILInjected.Token(Token = "0x6003EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEF4", Offset = "0x73FEF4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetMaskAt(int x, int y, LightMaskMode mode)
		{
			throw null;
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x0002C05D File Offset: 0x0002A25D
		[global::Cpp2ILInjected.Token(Token = "0x6003EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F024", Offset = "0x73F024", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		public void BlurPass1()
		{
			throw null;
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x0002C060 File Offset: 0x0002A260
		[global::Cpp2ILInjected.Token(Token = "0x6003EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F028", Offset = "0x73F028", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		public void BlurPass2()
		{
			throw null;
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x0002C063 File Offset: 0x0002A263
		[global::Cpp2ILInjected.Token(Token = "0x6003EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FFDC", Offset = "0x73FFDC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		public void Blur()
		{
			throw null;
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0002C066 File Offset: 0x0002A266
		[global::Cpp2ILInjected.Token(Token = "0x6003EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x740000", Offset = "0x740000", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ExportBatchFinished(int index)
		{
			throw null;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x0002C069 File Offset: 0x0002A269
		[global::Cpp2ILInjected.Token(Token = "0x170007A1")]
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003EBF")]
			[global::Cpp2ILInjected.Address(RVA = "0x740004", Offset = "0x740004", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur1PassThreaded", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur2PassThreaded", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.BatchProcessCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0002C06C File Offset: 0x0002A26C
		[global::Cpp2ILInjected.Token(Token = "0x6003EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x740084", Offset = "0x740084", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "BlurPass1", MemberParameters = new object[]
		{
			typeof(LightMap),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur1Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_ExportBatchFinishedCallback", ReturnType = typeof(ThreadedRenderManager.BatchProcessCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "WaitAndProcess", MemberParameters = new object[]
		{
			typeof(ThreadedRenderManager.BatchProcessCallback),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void Blur1PassThreaded(int start, int end)
		{
			throw null;
		}

		// Token: 0x06003822 RID: 14370
		[global::Cpp2ILInjected.Token(Token = "0x6003EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7401D4", Offset = "0x7401D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public unsafe static extern void Blur1PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06003823 RID: 14371
		[global::Cpp2ILInjected.Token(Token = "0x6003EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7401D8", Offset = "0x7401D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public unsafe static extern void Blur2PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06003824 RID: 14372 RVA: 0x0002C06F File Offset: 0x0002A26F
		[global::Cpp2ILInjected.Token(Token = "0x6003EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x740168", Offset = "0x740168", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur1PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Blur1Pass(int start, int end)
		{
			throw null;
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x0002C072 File Offset: 0x0002A272
		[global::Cpp2ILInjected.Token(Token = "0x6003EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7401DC", Offset = "0x7401DC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "BlurPass2", MemberParameters = new object[]
		{
			typeof(LightMap),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur2Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "get_ExportBatchFinishedCallback", ReturnType = typeof(ThreadedRenderManager.BatchProcessCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadedRenderManager), Member = "WaitAndProcess", MemberParameters = new object[]
		{
			typeof(ThreadedRenderManager.BatchProcessCallback),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void Blur2PassThreaded(int start, int end)
		{
			throw null;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x0002C075 File Offset: 0x0002A275
		[global::Cpp2ILInjected.Token(Token = "0x6003EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7402C0", Offset = "0x7402C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "DrawThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur2PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Blur2Pass(int start, int end)
		{
			throw null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0002C078 File Offset: 0x0002A278
		[global::Cpp2ILInjected.Token(Token = "0x6003EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FF0C", Offset = "0x73FF0C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessBlur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessBlur2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "BlurPass2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "Blur", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur1PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur1Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur2PassThreaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "Blur2Pass", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void BlurPass()
		{
			throw null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0002C07B File Offset: 0x0002A27B
		[global::Cpp2ILInjected.Token(Token = "0x6003EC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x74032C", Offset = "0x74032C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "DoColors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurLine2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ExecutePartialBlur(int pass)
		{
			throw null;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0002C07E File Offset: 0x0002A27E
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x74067C", Offset = "0x74067C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void BlurLine(int startIndex, int endIndex, int stride)
		{
			throw null;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0002C081 File Offset: 0x0002A281
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003EC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7404F8", Offset = "0x7404F8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightMap), Member = "ExecutePartialBlur", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void BlurLine2(int startIndex, int endIndex, int stride)
		{
			throw null;
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x0002C084 File Offset: 0x0002A284
		[global::Cpp2ILInjected.Token(Token = "0x6003ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FE88", Offset = "0x73FE88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int IndexOf(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0002C087 File Offset: 0x0002A287
		[global::Cpp2ILInjected.Token(Token = "0x6003ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x73E7D8", Offset = "0x73E7D8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "PreRenderPhase", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ProcessScan", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetSize(int width, int height)
		{
			throw null;
		}

		// Token: 0x04006830 RID: 26672
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <NonVisiblePadding>k__BackingField;

		// Token: 0x04006831 RID: 26673
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <Width>k__BackingField;

		// Token: 0x04006832 RID: 26674
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <Height>k__BackingField;

		// Token: 0x04006833 RID: 26675
		[global::Cpp2ILInjected.Token(Token = "0x4007D59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector3[] _colors;

		// Token: 0x04006834 RID: 26676
		[global::Cpp2ILInjected.Token(Token = "0x4007D5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public LightMaskMode[] _mask;

		// Token: 0x04006835 RID: 26677
		[global::Cpp2ILInjected.Token(Token = "0x4007D5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Vector3[] _decayColors;

		// Token: 0x04006836 RID: 26678
		[global::Cpp2ILInjected.Token(Token = "0x4007D5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private FastRandom _random;

		// Token: 0x04006837 RID: 26679
		[global::Cpp2ILInjected.Token(Token = "0x4007D5D")]
		private const int DEFAULT_WIDTH = 203;

		// Token: 0x04006838 RID: 26680
		[global::Cpp2ILInjected.Token(Token = "0x4007D5E")]
		private const int DEFAULT_HEIGHT = 203;

		// Token: 0x04006839 RID: 26681
		[global::Cpp2ILInjected.Token(Token = "0x4007D5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x0400683A RID: 26682
		[global::Cpp2ILInjected.Token(Token = "0x4007D60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ThreadedRenderManager _threadManager;
	}
}
