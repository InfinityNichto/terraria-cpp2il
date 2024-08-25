using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B31")]
	public abstract class PlatformIme : IImeService, IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000905")]
		public abstract string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005390")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000906")]
		public abstract bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005391")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000907")]
		public abstract uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005392")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000908")]
		public abstract uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005393")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000909")]
		public bool IsEnabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005394")]
			[global::Cpp2ILInjected.Address(RVA = "0x944AD4", Offset = "0x944AD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005395")]
			[global::Cpp2ILInjected.Address(RVA = "0x944ADC", Offset = "0x944ADC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005396")]
		[global::Cpp2ILInjected.Address(RVA = "0x944754", Offset = "0x944754", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsupportedPlatformIme), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected PlatformIme()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005397")]
		[global::Cpp2ILInjected.Address(RVA = "0x944AE8", Offset = "0x944AE8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddKeyListener(Action<char> listener)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005398")]
		[global::Cpp2ILInjected.Address(RVA = "0x944B90", Offset = "0x944B90", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveKeyListener(Action<char> listener)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005399")]
		[global::Cpp2ILInjected.Address(RVA = "0x9447E8", Offset = "0x9447E8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected void OnKeyPress(char character)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600539A")]
		public abstract string GetCandidate(uint index);

		[global::Cpp2ILInjected.Token(Token = "0x600539B")]
		[global::Cpp2ILInjected.Address(RVA = "0x944BE8", Offset = "0x944BE8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Enable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600539C")]
		[global::Cpp2ILInjected.Address(RVA = "0x944A10", Offset = "0x944A10", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Disable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600539D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C18", Offset = "0x944C18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600539E")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C1C", Offset = "0x944C1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600539F")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C20", Offset = "0x944C20", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60053A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C38", Offset = "0x944C38", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FnaIme), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60053A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x944CDC", Offset = "0x944CDC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008B31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <IsEnabled>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4008B32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<Action<char>> _keyPressCallbacks;

		[global::Cpp2ILInjected.Token(Token = "0x4008B33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _disposedValue;
	}
}
