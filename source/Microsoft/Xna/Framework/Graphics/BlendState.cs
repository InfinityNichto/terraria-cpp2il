using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200039B")]
	public class BlendState : GraphicsResource
	{
		[global::Cpp2ILInjected.Token(Token = "0x600187F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3E44", Offset = "0xAC3E44", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "set_BlendState", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "set_GraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001880")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3ED4", Offset = "0xAC3ED4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_AlphaBlendFunction", MemberParameters = new object[] { typeof(BlendFunction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_AlphaDestinationBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_AlphaSourceBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorBlendFunction", MemberParameters = new object[] { typeof(BlendFunction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorDestinationBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorSourceBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorWriteChannels", MemberParameters = new object[] { typeof(ColorWriteChannels) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorWriteChannels1", MemberParameters = new object[] { typeof(ColorWriteChannels) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorWriteChannels2", MemberParameters = new object[] { typeof(ColorWriteChannels) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_ColorWriteChannels3", MemberParameters = new object[] { typeof(ColorWriteChannels) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_BlendFactor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_MultiSampleMask", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "set_IndependentBlendEnable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Blend),
			typeof(Blend)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "Clone", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(TargetBlendState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_AlphaBlendFunction", MemberParameters = new object[] { typeof(BlendFunction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_AlphaDestinationBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_AlphaSourceBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_ColorBlendFunction", MemberParameters = new object[] { typeof(BlendFunction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_ColorDestinationBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_ColorSourceBlend", MemberParameters = new object[] { typeof(Blend) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "set_ColorWriteChannels", MemberParameters = new object[] { typeof(ColorWriteChannels) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ThrowIfBound()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000315")]
		public TargetBlendState this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001881")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3F58", Offset = "0xAC3F58", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000316")]
		public BlendFunction AlphaBlendFunction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001882")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3F68", Offset = "0xAC3F68", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001883")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3F78", Offset = "0xAC3F78", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000317")]
		public Blend AlphaDestinationBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001884")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3FD4", Offset = "0xAC3FD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001885")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3FE4", Offset = "0xAC3FE4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000318")]
		public Blend AlphaSourceBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001886")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4040", Offset = "0xAC4040", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001887")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4050", Offset = "0xAC4050", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000319")]
		public BlendFunction ColorBlendFunction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001888")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC40AC", Offset = "0xAC40AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001889")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC40BC", Offset = "0xAC40BC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031A")]
		public Blend ColorDestinationBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x600188A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4118", Offset = "0xAC4118", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600188B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4128", Offset = "0xAC4128", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031B")]
		public Blend ColorSourceBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x600188C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4184", Offset = "0xAC4184", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600188D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4194", Offset = "0xAC4194", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031C")]
		public ColorWriteChannels ColorWriteChannels
		{
			[global::Cpp2ILInjected.Token(Token = "0x600188E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC41F0", Offset = "0xAC41F0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600188F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4200", Offset = "0xAC4200", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031D")]
		public ColorWriteChannels ColorWriteChannels1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001890")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC425C", Offset = "0xAC425C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001891")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC426C", Offset = "0xAC426C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031E")]
		public ColorWriteChannels ColorWriteChannels2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001892")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC42A0", Offset = "0xAC42A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001893")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC42B0", Offset = "0xAC42B0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031F")]
		public ColorWriteChannels ColorWriteChannels3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001894")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC42E4", Offset = "0xAC42E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001895")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC42F4", Offset = "0xAC42F4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000320")]
		public Color BlendFactor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001896")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4328", Offset = "0xAC4328", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001897")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4330", Offset = "0xAC4330", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000321")]
		public int MultiSampleMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001898")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4354", Offset = "0xAC4354", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001899")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC435C", Offset = "0xAC435C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000322")]
		public bool IndependentBlendEnable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600189A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4380", Offset = "0xAC4380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600189B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4388", Offset = "0xAC4388", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC43AC", Offset = "0xAC43AC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Blend),
			typeof(Blend)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetBlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public BlendState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC45C4", Offset = "0xAC45C4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
		private BlendState(string name, Blend sourceBlend, Blend destinationBlend)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC4670", Offset = "0xAC4670", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "Clone", ReturnType = typeof(BlendState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetBlendState), Member = "Clone", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(TargetBlendState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private BlendState(BlendState cloneSource)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC48A8", Offset = "0xAC48A8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Blend),
			typeof(Blend)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static BlendState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC49DC", Offset = "0xAC49DC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal BlendState Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40026DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly TargetBlendState[] _targetBlendState;

		[global::Cpp2ILInjected.Token(Token = "0x40026DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly bool _defaultStateObject;

		[global::Cpp2ILInjected.Token(Token = "0x40026E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private Color _blendFactor;

		[global::Cpp2ILInjected.Token(Token = "0x40026E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _multiSampleMask;

		[global::Cpp2ILInjected.Token(Token = "0x40026E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool _independentBlendEnable;

		[global::Cpp2ILInjected.Token(Token = "0x40026E3")]
		public static readonly BlendState Additive;

		[global::Cpp2ILInjected.Token(Token = "0x40026E4")]
		public static readonly BlendState AlphaBlend;

		[global::Cpp2ILInjected.Token(Token = "0x40026E5")]
		public static readonly BlendState NonPremultiplied;

		[global::Cpp2ILInjected.Token(Token = "0x40026E6")]
		public static readonly BlendState Opaque;
	}
}
