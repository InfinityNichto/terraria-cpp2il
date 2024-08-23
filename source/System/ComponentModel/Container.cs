using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002DD RID: 733
	[global::Cpp2ILInjected.Token(Token = "0x20003DC")]
	public class Container : IContainer, IDisposable
	{
		// Token: 0x060017B4 RID: 6068 RVA: 0x000070D6 File Offset: 0x000052D6
		[global::Cpp2ILInjected.Token(Token = "0x6001A16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62AF8", Offset = "0x1E62AF8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000070D9 File Offset: 0x000052D9
		[global::Cpp2ILInjected.Token(Token = "0x6001A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62B98", Offset = "0x1E62B98", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Add(IComponent component)
		{
			throw null;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000070DC File Offset: 0x000052DC
		[global::Cpp2ILInjected.Token(Token = "0x6001A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62BA8", Offset = "0x1E62BA8", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void Add(IComponent component, string name)
		{
			throw null;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000070DF File Offset: 0x000052DF
		[global::Cpp2ILInjected.Token(Token = "0x6001A19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62FD4", Offset = "0x1E62FD4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			throw null;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000070E2 File Offset: 0x000052E2
		[global::Cpp2ILInjected.Token(Token = "0x6001A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63080", Offset = "0x1E63080", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "OnOwnerDisposed", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000070E5 File Offset: 0x000052E5
		[global::Cpp2ILInjected.Token(Token = "0x6001A1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E630EC", Offset = "0x1E630EC", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000070E8 File Offset: 0x000052E8
		[global::Cpp2ILInjected.Token(Token = "0x6001A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E633AC", Offset = "0x1E633AC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "GetService", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual object GetService(Type service)
		{
			throw null;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x000070EB File Offset: 0x000052EB
		[global::Cpp2ILInjected.Token(Token = "0x170005FD")]
		public virtual ComponentCollection Components
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63444", Offset = "0x1E63444", Length = "0x32C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ComponentCollection), Member = ".ctor", MemberParameters = new object[] { typeof(IComponent[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000070EE File Offset: 0x000052EE
		[global::Cpp2ILInjected.Token(Token = "0x6001A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63770", Offset = "0x1E63770", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Remove(IComponent component)
		{
			throw null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000070F1 File Offset: 0x000052F1
		[global::Cpp2ILInjected.Token(Token = "0x6001A1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63778", Offset = "0x1E63778", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Container), Member = "RemoveWithoutUnsiting", MemberParameters = new object[] { typeof(IComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void Remove(IComponent component, bool preserveSite)
		{
			throw null;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000070F4 File Offset: 0x000052F4
		[global::Cpp2ILInjected.Token(Token = "0x6001A20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63A1C", Offset = "0x1E63A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = "Remove", MemberParameters = new object[]
		{
			typeof(IComponent),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected void RemoveWithoutUnsiting(IComponent component)
		{
			throw null;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000070F7 File Offset: 0x000052F7
		[global::Cpp2ILInjected.Token(Token = "0x6001A21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63A24", Offset = "0x1E63A24", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		protected virtual void ValidateName(IComponent component, string name)
		{
			throw null;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000070FA File Offset: 0x000052FA
		[global::Cpp2ILInjected.Token(Token = "0x6001A22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63E64", Offset = "0x1E63E64", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = ".ctor", MemberParameters = new object[] { typeof(IComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Container()
		{
			throw null;
		}

		// Token: 0x04000EDD RID: 3805
		[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISite[] sites;

		// Token: 0x04000EDE RID: 3806
		[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int siteCount;

		// Token: 0x04000EDF RID: 3807
		[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ComponentCollection components;

		// Token: 0x04000EE0 RID: 3808
		[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ContainerFilterService filter;

		// Token: 0x04000EE1 RID: 3809
		[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool checkedFilter;

		// Token: 0x04000EE2 RID: 3810
		[global::Cpp2ILInjected.Token(Token = "0x4001300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object syncObj;

		// Token: 0x02000461 RID: 1121
		[global::Cpp2ILInjected.Token(Token = "0x20003DD")]
		private class Site : ISite, IServiceProvider
		{
			// Token: 0x06001EF8 RID: 7928 RVA: 0x00008567 File Offset: 0x00006767
			[global::Cpp2ILInjected.Token(Token = "0x6001A23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63044", Offset = "0x1E63044", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Site(IComponent component, Container container, string name)
			{
				throw null;
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0000856A File Offset: 0x0000676A
			[global::Cpp2ILInjected.Token(Token = "0x170005FE")]
			public IComponent Component
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A24")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63EC4", Offset = "0x1E63EC4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001EFA RID: 7930 RVA: 0x0000856D File Offset: 0x0000676D
			[global::Cpp2ILInjected.Token(Token = "0x170005FF")]
			public IContainer Container
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A25")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63ECC", Offset = "0x1E63ECC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001EFB RID: 7931 RVA: 0x00008570 File Offset: 0x00006770
			[global::Cpp2ILInjected.Token(Token = "0x6001A26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63ED4", Offset = "0x1E63ED4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public object GetService(Type service)
			{
				throw null;
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00008573 File Offset: 0x00006773
			[global::Cpp2ILInjected.Token(Token = "0x17000600")]
			public bool DesignMode
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A27")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63F90", Offset = "0x1E63F90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00008576 File Offset: 0x00006776
			// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00008579 File Offset: 0x00006779
			[global::Cpp2ILInjected.Token(Token = "0x17000601")]
			public string Name
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A28")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63F98", Offset = "0x1E63F98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001A29")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63FA0", Offset = "0x1E63FA0", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
				set
				{
					throw null;
				}
			}

			// Token: 0x040013A2 RID: 5026
			[global::Cpp2ILInjected.Token(Token = "0x4001301")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IComponent component;

			// Token: 0x040013A3 RID: 5027
			[global::Cpp2ILInjected.Token(Token = "0x4001302")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Container container;

			// Token: 0x040013A4 RID: 5028
			[global::Cpp2ILInjected.Token(Token = "0x4001303")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private string name;
		}
	}
}
