using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Localization.IME;

[Cpp2IlInjected.Token(Token = "0x2000735")]
public abstract class PlatformIme : IImeService, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007196")]
	private readonly List<Action<char>> _keyPressCallbacks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007197")]
	private bool _disposedValue;

	[Cpp2IlInjected.Token(Token = "0x17000803")]
	public abstract string CompositionString
	{
		[Cpp2IlInjected.Token(Token = "0x600471A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000804")]
	public abstract bool IsCandidateListVisible
	{
		[Cpp2IlInjected.Token(Token = "0x600471B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000805")]
	public abstract uint SelectedCandidate
	{
		[Cpp2IlInjected.Token(Token = "0x600471C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000806")]
	public abstract uint CandidateCount
	{
		[Cpp2IlInjected.Token(Token = "0x600471D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000807")]
	public bool IsEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x600471E")]
		[Cpp2IlInjected.Address(RVA = "0xF913BC", Offset = "0xF913BC", VA = "0xF913BC", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600471F")]
		[Cpp2IlInjected.Address(RVA = "0xF913C4", Offset = "0xF913C4", VA = "0xF913C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004720")]
	[Cpp2IlInjected.Address(RVA = "0xF90FD8", Offset = "0xF90FD8", VA = "0xF90FD8")]
	protected PlatformIme()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004721")]
	[Cpp2IlInjected.Address(RVA = "0xF913CC", Offset = "0xF913CC", VA = "0xF913CC", Slot = "12")]
	public void AddKeyListener(Action<char> listener)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004722")]
	[Cpp2IlInjected.Address(RVA = "0xF91430", Offset = "0xF91430", VA = "0xF91430", Slot = "13")]
	public void RemoveKeyListener(Action<char> listener)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004723")]
	[Cpp2IlInjected.Address(RVA = "0xF91074", Offset = "0xF91074", VA = "0xF91074")]
	protected void OnKeyPress(char character)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004724")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract string GetCandidate(uint index);

	[Cpp2IlInjected.Token(Token = "0x6004725")]
	[Cpp2IlInjected.Address(RVA = "0xF91494", Offset = "0xF91494", VA = "0xF91494", Slot = "10")]
	public void Enable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004726")]
	[Cpp2IlInjected.Address(RVA = "0xF912A4", Offset = "0xF912A4", VA = "0xF912A4", Slot = "11")]
	public void Disable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004727")]
	[Cpp2IlInjected.Address(RVA = "0xF914CC", Offset = "0xF914CC", VA = "0xF914CC", Slot = "20")]
	protected virtual void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004728")]
	[Cpp2IlInjected.Address(RVA = "0xF914D0", Offset = "0xF914D0", VA = "0xF914D0", Slot = "21")]
	protected virtual void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004729")]
	[Cpp2IlInjected.Address(RVA = "0xF914D4", Offset = "0xF914D4", VA = "0xF914D4", Slot = "22")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600472A")]
	[Cpp2IlInjected.Address(RVA = "0xF91348", Offset = "0xF91348", VA = "0xF91348", Slot = "1")]
	~PlatformIme()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600472B")]
	[Cpp2IlInjected.Address(RVA = "0xF914E8", Offset = "0xF914E8", VA = "0xF914E8", Slot = "14")]
	public void Dispose()
	{
	}
}
