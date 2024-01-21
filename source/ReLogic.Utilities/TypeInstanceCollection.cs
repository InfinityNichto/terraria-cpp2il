using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000716")]
internal class TypeInstanceCollection<BaseType> : IDisposable where BaseType : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007159")]
	private Dictionary<Type, BaseType> _services;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400715A")]
	private bool _disposedValue;

	[Cpp2IlInjected.Token(Token = "0x6004648")]
	[Cpp2IlInjected.Address(RVA = "0x160771C", Offset = "0x160771C", VA = "0x160771C")]
	public void Register<T>(T instance) where T : BaseType
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004649")]
	[Cpp2IlInjected.Address(RVA = "0x15ADD50", Offset = "0x15ADD50", VA = "0x15ADD50")]
	public T Get<T>() where T : BaseType
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600464A")]
	[Cpp2IlInjected.Address(RVA = "0x1607834", Offset = "0x1607834", VA = "0x1607834")]
	public void Remove<T>() where T : BaseType
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600464B")]
	[Cpp2IlInjected.Address(RVA = "0x16786A8", Offset = "0x16786A8", VA = "0x16786A8")]
	public bool Has<T>() where T : BaseType
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600464C")]
	[Cpp2IlInjected.Address(RVA = "0x1978A3C", Offset = "0x1978A3C", VA = "0x1978A3C")]
	public bool Has(Type type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600464D")]
	[Cpp2IlInjected.Address(RVA = "0x16075E8", Offset = "0x16075E8", VA = "0x16075E8")]
	public void IfHas<T>(Action<T> callback) where T : BaseType
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600464E")]
	[Cpp2IlInjected.Address(RVA = "0x206FB30", Offset = "0x206FB30", VA = "0x206FB30")]
	public U IfHas<U, T>(Func<T, U> callback) where T : BaseType
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600464F")]
	[Cpp2IlInjected.Address(RVA = "0x1978A54", Offset = "0x1978A54", VA = "0x1978A54", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004650")]
	[Cpp2IlInjected.Address(RVA = "0x1978CD0", Offset = "0x1978CD0", VA = "0x1978CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004651")]
	[Cpp2IlInjected.Address(RVA = "0x1978CE4", Offset = "0x1978CE4", VA = "0x1978CE4")]
	public TypeInstanceCollection()
	{
	}
}
