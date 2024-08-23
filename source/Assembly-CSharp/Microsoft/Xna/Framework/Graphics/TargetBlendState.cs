using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002D3 RID: 723
	[global::Cpp2ILInjected.Token(Token = "0x20003A4")]
	public class TargetBlendState
	{
		// Token: 0x0600177C RID: 6012 RVA: 0x000260DE File Offset: 0x000242DE
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

		// Token: 0x0600177D RID: 6013 RVA: 0x000260E1 File Offset: 0x000242E1
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x000260E4 File Offset: 0x000242E4
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x000260E7 File Offset: 0x000242E7
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x000260EA File Offset: 0x000242EA
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x000260ED File Offset: 0x000242ED
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x000260F0 File Offset: 0x000242F0
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x000260F3 File Offset: 0x000242F3
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000260F6 File Offset: 0x000242F6
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x000260F9 File Offset: 0x000242F9
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x000260FC File Offset: 0x000242FC
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x000260FF File Offset: 0x000242FF
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00026102 File Offset: 0x00024302
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x00026105 File Offset: 0x00024305
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00026108 File Offset: 0x00024308
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0002610B File Offset: 0x0002430B
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

		// Token: 0x040020D9 RID: 8409
		[global::Cpp2ILInjected.Token(Token = "0x4002735")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly BlendState _parent;

		// Token: 0x040020DA RID: 8410
		[global::Cpp2ILInjected.Token(Token = "0x4002736")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BlendFunction _alphaBlendFunction;

		// Token: 0x040020DB RID: 8411
		[global::Cpp2ILInjected.Token(Token = "0x4002737")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Blend _alphaDestinationBlend;

		// Token: 0x040020DC RID: 8412
		[global::Cpp2ILInjected.Token(Token = "0x4002738")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Blend _alphaSourceBlend;

		// Token: 0x040020DD RID: 8413
		[global::Cpp2ILInjected.Token(Token = "0x4002739")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private BlendFunction _colorBlendFunction;

		// Token: 0x040020DE RID: 8414
		[global::Cpp2ILInjected.Token(Token = "0x400273A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Blend _colorDestinationBlend;

		// Token: 0x040020DF RID: 8415
		[global::Cpp2ILInjected.Token(Token = "0x400273B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Blend _colorSourceBlend;

		// Token: 0x040020E0 RID: 8416
		[global::Cpp2ILInjected.Token(Token = "0x400273C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ColorWriteChannels _colorWriteChannels;
	}
}
