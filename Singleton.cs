using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class Singleton<T> : ScriptableObject where T : Singleton<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static T _instance;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static bool _initialised;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static T Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1978D54", Offset = "0x1978D54", VA = "0x1978D54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1978D4C", Offset = "0x1978D4C", VA = "0x1978D4C")]
	public Singleton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1978E5C", Offset = "0x1978E5C", VA = "0x1978E5C")]
	public static void Create()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1979088", Offset = "0x1979088", VA = "0x1979088")]
	private static void CreateOnMainThread(object resourceId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1979220", Offset = "0x1979220", VA = "0x1979220")]
	public static void Create(string resourceId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1979D14", Offset = "0x1979D14", VA = "0x1979D14")]
	public static void Destroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x197A22C", Offset = "0x197A22C", VA = "0x197A22C")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x197A4D4", Offset = "0x197A4D4", VA = "0x197A4D4")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x197A77C", Offset = "0x197A77C", VA = "0x197A77C")]
	private static void Cleanup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x197A97C", Offset = "0x197A97C", VA = "0x197A97C", Slot = "4")]
	public virtual void Init()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x197A980", Offset = "0x197A980", VA = "0x197A980", Slot = "5")]
	public virtual void Shutdown()
	{
	}
}
