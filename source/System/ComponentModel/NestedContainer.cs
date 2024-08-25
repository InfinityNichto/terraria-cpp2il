using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A8")]
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E557BC", Offset = "0x1E557BC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public NestedContainer(IComponent owner)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005A0")]
		public IComponent Owner
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E55904", Offset = "0x1E55904", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005A1")]
		protected virtual string OwnerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5590C", Offset = "0x1E5590C", Length = "0x264")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55B70", Offset = "0x1E55B70", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override ISite CreateSite(IComponent component, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55C68", Offset = "0x1E55C68", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55D6C", Offset = "0x1E55D6C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = "GetService", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override object GetService(Type service)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55E20", Offset = "0x1E55E20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = "Dispose", ReturnType = typeof(void))]
		private void OnOwnerDisposed(object sender, EventArgs e)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly IComponent <Owner>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x20003A9")]
		private class Site : INestedSite, ISite, IServiceProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E55C2C", Offset = "0x1E55C2C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Site(IComponent component, NestedContainer container, string name)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005A2")]
			public IComponent Component
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60018B3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E55E28", Offset = "0x1E55E28", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005A3")]
			public IContainer Container
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60018B4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E55E30", Offset = "0x1E55E30", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60018B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E55E38", Offset = "0x1E55E38", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public object GetService(Type service)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005A4")]
			public bool DesignMode
			{
				[global::Cpp2ILInjected.Token(Token = "0x60018B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E55F34", Offset = "0x1E55F34", Length = "0x1C8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005A5")]
			public string FullName
			{
				[global::Cpp2ILInjected.Token(Token = "0x60018B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E560FC", Offset = "0x1E560FC", Length = "0xF8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
				{
					typeof(IFormatProvider),
					typeof(string),
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005A6")]
			public string Name
			{
				[global::Cpp2ILInjected.Token(Token = "0x60018B8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E561F4", Offset = "0x1E561F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60018B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E561FC", Offset = "0x1E561FC", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001297")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _name;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4001298")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly IComponent <Component>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4001299")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly IContainer <Container>k__BackingField;
		}
	}
}
