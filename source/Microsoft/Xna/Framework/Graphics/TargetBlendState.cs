using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A4")]
	public class TargetBlendState
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC4540", Offset = "0xAC4540", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TargetBlendState), Member = "Clone", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(TargetBlendState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
		internal TargetBlendState(BlendState parent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC47D4", Offset = "0xAC47D4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetBlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TargetBlendState Clone(BlendState parent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000344")]
		public BlendFunction AlphaBlendFunction
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018FA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5C9C", Offset = "0xAC5C9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018FB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC3FAC", Offset = "0xAC3FAC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000345")]
		public Blend AlphaDestinationBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018FC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CA4", Offset = "0xAC5CA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018FD")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4018", Offset = "0xAC4018", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000346")]
		public Blend AlphaSourceBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018FE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CAC", Offset = "0xAC5CAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018FF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4084", Offset = "0xAC4084", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000347")]
		public BlendFunction ColorBlendFunction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001900")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CB4", Offset = "0xAC5CB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001901")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC40F0", Offset = "0xAC40F0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000348")]
		public Blend ColorDestinationBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001902")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CBC", Offset = "0xAC5CBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001903")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC415C", Offset = "0xAC415C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000349")]
		public Blend ColorSourceBlend
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001904")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CC4", Offset = "0xAC5CC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001905")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC41C8", Offset = "0xAC41C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034A")]
		public ColorWriteChannels ColorWriteChannels
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001906")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CCC", Offset = "0xAC5CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001907")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC4234", Offset = "0xAC4234", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "ThrowIfBound", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002735")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly BlendState _parent;

		[global::Cpp2ILInjected.Token(Token = "0x4002736")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BlendFunction _alphaBlendFunction;

		[global::Cpp2ILInjected.Token(Token = "0x4002737")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Blend _alphaDestinationBlend;

		[global::Cpp2ILInjected.Token(Token = "0x4002738")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Blend _alphaSourceBlend;

		[global::Cpp2ILInjected.Token(Token = "0x4002739")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private BlendFunction _colorBlendFunction;

		[global::Cpp2ILInjected.Token(Token = "0x400273A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Blend _colorDestinationBlend;

		[global::Cpp2ILInjected.Token(Token = "0x400273B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Blend _colorSourceBlend;

		[global::Cpp2ILInjected.Token(Token = "0x400273C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ColorWriteChannels _colorWriteChannels;
	}
}
