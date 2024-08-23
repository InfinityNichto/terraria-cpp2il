using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002CA RID: 714
	[global::Cpp2ILInjected.Token(Token = "0x200039B")]
	public class BlendState : GraphicsResource
	{
		// Token: 0x06001703 RID: 5891 RVA: 0x00025F73 File Offset: 0x00024173
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

		// Token: 0x06001704 RID: 5892 RVA: 0x00025F76 File Offset: 0x00024176
		[global::Cpp2ILInjected.Token(Token = "0x6001880")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC3ED4", Offset = "0xAC3ED4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ThrowIfBound()
		{
			throw null;
		}

		// Token: 0x170002EA RID: 746
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

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00025F7C File Offset: 0x0002417C
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x00025F7F File Offset: 0x0002417F
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x00025F82 File Offset: 0x00024182
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00025F85 File Offset: 0x00024185
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00025F88 File Offset: 0x00024188
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00025F8B File Offset: 0x0002418B
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00025F8E File Offset: 0x0002418E
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00025F91 File Offset: 0x00024191
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00025F94 File Offset: 0x00024194
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00025F97 File Offset: 0x00024197
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00025F9A File Offset: 0x0002419A
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x00025F9D File Offset: 0x0002419D
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00025FA0 File Offset: 0x000241A0
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x00025FA3 File Offset: 0x000241A3
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00025FA6 File Offset: 0x000241A6
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00025FA9 File Offset: 0x000241A9
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00025FAC File Offset: 0x000241AC
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00025FAF File Offset: 0x000241AF
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00025FB2 File Offset: 0x000241B2
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00025FB5 File Offset: 0x000241B5
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00025FB8 File Offset: 0x000241B8
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00025FBB File Offset: 0x000241BB
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00025FBE File Offset: 0x000241BE
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00025FC1 File Offset: 0x000241C1
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00025FC4 File Offset: 0x000241C4
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00025FC7 File Offset: 0x000241C7
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

		// Token: 0x06001720 RID: 5920 RVA: 0x00025FCA File Offset: 0x000241CA
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

		// Token: 0x06001721 RID: 5921 RVA: 0x00025FCD File Offset: 0x000241CD
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

		// Token: 0x06001722 RID: 5922 RVA: 0x00025FD0 File Offset: 0x000241D0
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

		// Token: 0x06001723 RID: 5923 RVA: 0x00025FD3 File Offset: 0x000241D3
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

		// Token: 0x06001724 RID: 5924 RVA: 0x00025FD6 File Offset: 0x000241D6
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

		// Token: 0x04002082 RID: 8322
		[global::Cpp2ILInjected.Token(Token = "0x40026DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly TargetBlendState[] _targetBlendState;

		// Token: 0x04002083 RID: 8323
		[global::Cpp2ILInjected.Token(Token = "0x40026DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly bool _defaultStateObject;

		// Token: 0x04002084 RID: 8324
		[global::Cpp2ILInjected.Token(Token = "0x40026E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private Color _blendFactor;

		// Token: 0x04002085 RID: 8325
		[global::Cpp2ILInjected.Token(Token = "0x40026E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _multiSampleMask;

		// Token: 0x04002086 RID: 8326
		[global::Cpp2ILInjected.Token(Token = "0x40026E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool _independentBlendEnable;

		// Token: 0x04002087 RID: 8327
		[global::Cpp2ILInjected.Token(Token = "0x40026E3")]
		public static readonly BlendState Additive;

		// Token: 0x04002088 RID: 8328
		[global::Cpp2ILInjected.Token(Token = "0x40026E4")]
		public static readonly BlendState AlphaBlend;

		// Token: 0x04002089 RID: 8329
		[global::Cpp2ILInjected.Token(Token = "0x40026E5")]
		public static readonly BlendState NonPremultiplied;

		// Token: 0x0400208A RID: 8330
		[global::Cpp2ILInjected.Token(Token = "0x40026E6")]
		public static readonly BlendState Opaque;
	}
}
