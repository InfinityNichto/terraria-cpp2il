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
	[global::Cpp2ILInjected.Token(Token = "0x2000779")]
	public class LightMap
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEB4", Offset = "0x73FEB4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void GetLight(int x, int y, out Vector3 color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEDC", Offset = "0x73FEDC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public LightMaskMode GetMask(int x, int y)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FEF4", Offset = "0x73FEF4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetMaskAt(int x, int y, LightMaskMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F024", Offset = "0x73F024", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		public void BlurPass1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x73F028", Offset = "0x73F028", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		public void BlurPass2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FFDC", Offset = "0x73FFDC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightMap), Member = "BlurPass", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextSeed", ReturnType = typeof(void))]
		public void Blur()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x740000", Offset = "0x740000", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ExportBatchFinished(int index)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7401D4", Offset = "0x7401D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public unsafe static extern void Blur1PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		[global::Cpp2ILInjected.Token(Token = "0x6003EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7401D8", Offset = "0x7401D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public unsafe static extern void Blur2PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

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

		[global::Cpp2ILInjected.Token(Token = "0x6003ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x73FE88", Offset = "0x73FE88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int IndexOf(int x, int y)
		{
			throw null;
		}

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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <NonVisiblePadding>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <Width>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <Height>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007D59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector3[] _colors;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public LightMaskMode[] _mask;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Vector3[] _decayColors;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private FastRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5D")]
		private const int DEFAULT_WIDTH = 203;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5E")]
		private const int DEFAULT_HEIGHT = 203;

		[global::Cpp2ILInjected.Token(Token = "0x4007D5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4007D60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ThreadedRenderManager _threadManager;
	}
}
