using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content;

[Cpp2IlInjected.Token(Token = "0x20002F3")]
public class ThreadContentRequest
{
	[Cpp2IlInjected.Token(Token = "0x200082C")]
	public delegate object ObjectCreate(Object asset);

	[Cpp2IlInjected.Token(Token = "0x200082D")]
	public delegate object ObjectCreate2(Object asset, Object asset2);

	[Cpp2IlInjected.Token(Token = "0x200082E")]
	public delegate object ObjectCreate3(Object asset, Object asset2, Object asset3);

	[Cpp2IlInjected.Token(Token = "0x4002159")]
	private static ConcurrentQueue<ThreadContentRequest> _pendingRequests;

	[Cpp2IlInjected.Token(Token = "0x400215A")]
	private static List<ThreadContentRequest> _activeRequests;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400215B")]
	private object _lockObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400215C")]
	private readonly string _asset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400215D")]
	private readonly string _asset2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400215E")]
	private readonly string _asset3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400215F")]
	private ResourceRequest _loadRequest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002160")]
	private ResourceRequest _loadRequest2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002161")]
	private ResourceRequest _loadRequest3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002162")]
	private Object _resource;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002163")]
	private Object _resource2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002164")]
	private Object _resource3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002165")]
	private bool _loaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002166")]
	private ObjectCreate _createFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002167")]
	private ObjectCreate2 _createFunction2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002168")]
	private ObjectCreate3 _createFunction3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002169")]
	private object _constructedObject;

	[Cpp2IlInjected.Token(Token = "0x6001902")]
	[Cpp2IlInjected.Address(RVA = "0x15AB680", Offset = "0x15AB680", VA = "0x15AB680")]
	public static T ConstructOnMainThread<T>(string asset, ObjectCreate createFunction) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001903")]
	[Cpp2IlInjected.Address(RVA = "0x15AB7C4", Offset = "0x15AB7C4", VA = "0x15AB7C4")]
	public static T ConstructOnMainThread<T>(string asset, string asset2, ObjectCreate2 createFunction) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001904")]
	[Cpp2IlInjected.Address(RVA = "0x15AB91C", Offset = "0x15AB91C", VA = "0x15AB91C")]
	public static T ConstructOnMainThread<T>(string asset, string asset2, string asset3, ObjectCreate3 createFunction) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001905")]
	[Cpp2IlInjected.Address(RVA = "0x12EA970", Offset = "0x12EA970", VA = "0x12EA970")]
	public static Object Load(string asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001906")]
	[Cpp2IlInjected.Address(RVA = "0x12EAB74", Offset = "0x12EAB74", VA = "0x12EAB74")]
	public static void UpdatingLoading()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001907")]
	[Cpp2IlInjected.Address(RVA = "0x12EAA24", Offset = "0x12EAA24", VA = "0x12EAA24")]
	public ThreadContentRequest(string asset, [Optional] ObjectCreate createFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001908")]
	[Cpp2IlInjected.Address(RVA = "0x12EAFE4", Offset = "0x12EAFE4", VA = "0x12EAFE4")]
	public ThreadContentRequest(string asset, string asset2, [Optional] ObjectCreate2 createFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001909")]
	[Cpp2IlInjected.Address(RVA = "0x12EB070", Offset = "0x12EB070", VA = "0x12EB070")]
	public ThreadContentRequest(string asset, string asset2, string asset3, [Optional] ObjectCreate3 createFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600190A")]
	[Cpp2IlInjected.Address(RVA = "0x12EADCC", Offset = "0x12EADCC", VA = "0x12EADCC")]
	private void BeginLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600190B")]
	[Cpp2IlInjected.Address(RVA = "0x12EAE38", Offset = "0x12EAE38", VA = "0x12EAE38")]
	private bool UpdateLoad()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600190C")]
	[Cpp2IlInjected.Address(RVA = "0x12EAAA8", Offset = "0x12EAAA8", VA = "0x12EAAA8")]
	public Object LoadFromMainThread()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600190D")]
	[Cpp2IlInjected.Address(RVA = "0x12EB104", Offset = "0x12EB104", VA = "0x12EB104")]
	public object ConstructFromMainThread()
	{
		return null;
	}
}
