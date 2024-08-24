using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000739 RID: 1849
	[global::Cpp2ILInjected.Token(Token = "0x2000B39")]
	public sealed class Asset<T> : IAsset, IDisposable where T : class
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0002EB0E File Offset: 0x0002CD0E
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x0002EB11 File Offset: 0x0002CD11
		[global::Cpp2ILInjected.Token(Token = "0x1700090F")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4ECC", Offset = "0x17F4ECC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4ED4", Offset = "0x17F4ED4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0002EB14 File Offset: 0x0002CD14
		[global::Cpp2ILInjected.Token(Token = "0x17000910")]
		public bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4EDC", Offset = "0x17F4EDC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x0002EB17 File Offset: 0x0002CD17
		// (set) Token: 0x06004708 RID: 18184 RVA: 0x0002EB1A File Offset: 0x0002CD1A
		[global::Cpp2ILInjected.Token(Token = "0x17000911")]
		public AssetState State
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F04", Offset = "0x17F4F04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F0C", Offset = "0x17F4F0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x0002EB1D File Offset: 0x0002CD1D
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x0002EB20 File Offset: 0x0002CD20
		[global::Cpp2ILInjected.Token(Token = "0x17000912")]
		public bool IsDisposed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F14", Offset = "0x17F4F14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F1C", Offset = "0x17F4F1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x0002EB23 File Offset: 0x0002CD23
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x0002EB26 File Offset: 0x0002CD26
		[global::Cpp2ILInjected.Token(Token = "0x17000913")]
		public IContentSource Source
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F28", Offset = "0x17F4F28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F30", Offset = "0x17F4F30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x0002EB29 File Offset: 0x0002CD29
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		[global::Cpp2ILInjected.Token(Token = "0x17000914")]
		public T Value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F38", Offset = "0x17F4F38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F4F40", Offset = "0x17F4F40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x0002EB2F File Offset: 0x0002CD2F
		[global::Cpp2ILInjected.Token(Token = "0x60053C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F4F48", Offset = "0x17F4F48", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ActionUnityLoad()
		{
			throw null;
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x0002EB32 File Offset: 0x0002CD32
		[global::Cpp2ILInjected.Token(Token = "0x60053C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F5000", Offset = "0x17F5000", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Asset(string name)
		{
			throw null;
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x0002EB35 File Offset: 0x0002CD35
		[global::Cpp2ILInjected.Token(Token = "0x60053CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F505C", Offset = "0x17F505C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static explicit operator T(Asset<T> asset)
		{
			throw null;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x0002EB38 File Offset: 0x0002CD38
		[global::Cpp2ILInjected.Token(Token = "0x60053CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F50CC", Offset = "0x17F50CC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void Unload()
		{
			throw null;
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x0002EB3B File Offset: 0x0002CD3B
		[global::Cpp2ILInjected.Token(Token = "0x60053CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F51E8", Offset = "0x17F51E8", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void SubmitLoadedContent(T value, IContentSource source)
		{
			throw null;
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x0002EB3E File Offset: 0x0002CD3E
		[global::Cpp2ILInjected.Token(Token = "0x60053CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F5360", Offset = "0x17F5360", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetToLoadingState()
		{
			throw null;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x0002EB41 File Offset: 0x0002CD41
		[global::Cpp2ILInjected.Token(Token = "0x60053CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F5378", Offset = "0x17F5378", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x0002EB44 File Offset: 0x0002CD44
		[global::Cpp2ILInjected.Token(Token = "0x60053CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F54E4", Offset = "0x17F54E4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x0002EB47 File Offset: 0x0002CD47
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60053D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F54FC", Offset = "0x17F54FC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Asset()
		{
			throw null;
		}

		// Token: 0x04007351 RID: 29521
		[global::Cpp2ILInjected.Token(Token = "0x4008CF0")]
		public static readonly Asset<T> Empty;

		// Token: 0x04007352 RID: 29522
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string <Name>k__BackingField;

		// Token: 0x04007353 RID: 29523
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AssetState <State>k__BackingField;

		// Token: 0x04007354 RID: 29524
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool <IsDisposed>k__BackingField;

		// Token: 0x04007355 RID: 29525
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IContentSource <Source>k__BackingField;

		// Token: 0x04007356 RID: 29526
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T <Value>k__BackingField;
	}
}
