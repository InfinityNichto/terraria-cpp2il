using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000387")]
	public struct RenderTargetBinding
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000307")]
		public Texture RenderTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017F9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB4140", Offset = "0xAB4140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000308")]
		public int ArraySlice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017FA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB4148", Offset = "0xAB4148", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000309")]
		internal DepthFormat DepthFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017FB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB4150", Offset = "0xAB4150", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4158", Offset = "0xAB4158", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTargetBinding), Member = "op_Implicit", MemberParameters = new object[] { typeof(RenderTarget2D) }, ReturnType = typeof(RenderTargetBinding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public RenderTargetBinding(RenderTarget2D renderTarget)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB41C0", Offset = "0xAB41C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTargetBinding), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTarget2D) }, ReturnType = typeof(void))]
		public static implicit operator RenderTargetBinding(RenderTarget2D renderTarget)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002639")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Texture _renderTarget;

		[global::Cpp2ILInjected.Token(Token = "0x400263A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly int _arraySlice;

		[global::Cpp2ILInjected.Token(Token = "0x400263B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private DepthFormat _depthFormat;
	}
}
