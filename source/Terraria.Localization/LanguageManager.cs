using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria.Localization;

[Cpp2IlInjected.Token(Token = "0x20003B9")]
public class LanguageManager
{
	[Cpp2IlInjected.Token(Token = "0x400326D")]
	public static LanguageManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4003271")]
	private readonly Dictionary<string, LocalizedText> _localizedTexts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003272")]
	private readonly Dictionary<string, List<string>> _categoryGroupedKeys;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003273")]
	private GameCulture _fallbackCulture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4003274")]
	public bool intialLoadDone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4003275")]
	public GameCulture delayedActiveCulture;

	[Cpp2IlInjected.Token(Token = "0x170005F1")]
	public GameCulture ActiveCulture
	{
		[Cpp2IlInjected.Token(Token = "0x6002EF3")]
		[Cpp2IlInjected.Address(RVA = "0x4776DC", Offset = "0x4776DC", VA = "0x4776DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002EF4")]
		[Cpp2IlInjected.Address(RVA = "0x4776E4", Offset = "0x4776E4", VA = "0x4776E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event LanguageChangeCallback OnLanguageChanging
	{
		[Cpp2IlInjected.Token(Token = "0x6002EEF")]
		[Cpp2IlInjected.Address(RVA = "0x47741C", Offset = "0x47741C", VA = "0x47741C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002EF0")]
		[Cpp2IlInjected.Address(RVA = "0x4774CC", Offset = "0x4774CC", VA = "0x4774CC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event LanguageChangeCallback OnLanguageChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6002EF1")]
		[Cpp2IlInjected.Address(RVA = "0x47757C", Offset = "0x47757C", VA = "0x47757C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002EF2")]
		[Cpp2IlInjected.Address(RVA = "0x47762C", Offset = "0x47762C", VA = "0x47762C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002EF5")]
	[Cpp2IlInjected.Address(RVA = "0x4776EC", Offset = "0x4776EC", VA = "0x4776EC")]
	private LanguageManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EF6")]
	[Cpp2IlInjected.Address(RVA = "0x4762BC", Offset = "0x4762BC", VA = "0x4762BC")]
	public int GetCategorySize(string name)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EF7")]
	[Cpp2IlInjected.Address(RVA = "0x477898", Offset = "0x477898", VA = "0x477898")]
	public void SetLanguage(int legacyId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EF8")]
	[Cpp2IlInjected.Address(RVA = "0x477A28", Offset = "0x477A28", VA = "0x477A28")]
	public void SetLanguage(string cultureName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EF9")]
	[Cpp2IlInjected.Address(RVA = "0x477AB0", Offset = "0x477AB0", VA = "0x477AB0")]
	public int EstimateWordCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFA")]
	[Cpp2IlInjected.Address(RVA = "0x477D34", Offset = "0x477D34", VA = "0x477D34")]
	private void SetAllTextValuesToKeys()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFB")]
	[Cpp2IlInjected.Address(RVA = "0x477E54", Offset = "0x477E54", VA = "0x477E54")]
	private string[] GetLanguageFilesForCulture(GameCulture culture)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFC")]
	[Cpp2IlInjected.Address(RVA = "0x477FA4", Offset = "0x477FA4", VA = "0x477FA4")]
	public void DelayedInit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFD")]
	[Cpp2IlInjected.Address(RVA = "0x477920", Offset = "0x477920", VA = "0x477920")]
	public void SetLanguage(GameCulture culture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFE")]
	[Cpp2IlInjected.Address(RVA = "0x477FB4", Offset = "0x477FB4", VA = "0x477FB4")]
	private void LoadLanguage(GameCulture culture, bool processCopyCommands = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EFF")]
	[Cpp2IlInjected.Address(RVA = "0x477FF0", Offset = "0x477FF0", VA = "0x477FF0")]
	private void LoadFilesForCulture(GameCulture culture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F00")]
	[Cpp2IlInjected.Address(RVA = "0x4784FC", Offset = "0x4784FC", VA = "0x4784FC")]
	private void ProcessCopyCommandsInTexts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F01")]
	[Cpp2IlInjected.Address(RVA = "0x4786D4", Offset = "0x4786D4", VA = "0x4786D4")]
	public void LoadLanguageFromFileText(string fileText)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F02")]
	[Cpp2IlInjected.Address(RVA = "0x478F1C", Offset = "0x478F1C", VA = "0x478F1C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393A34", Offset = "0x393A34")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393A34", Offset = "0x393A34")]
	private void ValidateAllCharactersContainedInFont(SpriteFont font)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F03")]
	[Cpp2IlInjected.Address(RVA = "0x4763D4", Offset = "0x4763D4", VA = "0x4763D4")]
	public LocalizedText[] FindAll(Regex regex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F04")]
	[Cpp2IlInjected.Address(RVA = "0x4766C8", Offset = "0x4766C8", VA = "0x4766C8")]
	public LocalizedText[] FindAll(LanguageSearchFilter filter)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F05")]
	[Cpp2IlInjected.Address(RVA = "0x4768E4", Offset = "0x4768E4", VA = "0x4768E4")]
	public LocalizedText[] FindAll(string categoryName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F06")]
	[Cpp2IlInjected.Address(RVA = "0x476ACC", Offset = "0x476ACC", VA = "0x476ACC")]
	public LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F07")]
	[Cpp2IlInjected.Address(RVA = "0x476E20", Offset = "0x476E20", VA = "0x476E20")]
	public LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F08")]
	[Cpp2IlInjected.Address(RVA = "0x4793CC", Offset = "0x4793CC", VA = "0x4793CC")]
	public LocalizedText RandomFromCategories(string[] categoryNames, ref int keyIndexToSkip, [Optional] UnifiedRandom random)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F09")]
	[Cpp2IlInjected.Address(RVA = "0x47997C", Offset = "0x47997C", VA = "0x47997C")]
	public LocalizedText IndexedFromCategory(string categoryName, int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0A")]
	[Cpp2IlInjected.Address(RVA = "0x4761D4", Offset = "0x4761D4", VA = "0x4761D4")]
	public bool Exists(string key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0B")]
	[Cpp2IlInjected.Address(RVA = "0x4754A8", Offset = "0x4754A8", VA = "0x4754A8")]
	public LocalizedText GetText(string key)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0C")]
	[Cpp2IlInjected.Address(RVA = "0x475600", Offset = "0x475600", VA = "0x475600")]
	public string GetTextValue(string key)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0D")]
	[Cpp2IlInjected.Address(RVA = "0x47571C", Offset = "0x47571C", VA = "0x47571C")]
	public string GetTextValue(string key, object arg0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0E")]
	[Cpp2IlInjected.Address(RVA = "0x47585C", Offset = "0x47585C", VA = "0x47585C")]
	public string GetTextValue(string key, object arg0, object arg1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F0F")]
	[Cpp2IlInjected.Address(RVA = "0x4759AC", Offset = "0x4759AC", VA = "0x4759AC")]
	public string GetTextValue(string key, object arg0, object arg1, object arg2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F10")]
	[Cpp2IlInjected.Address(RVA = "0x475AFC", Offset = "0x475AFC", VA = "0x475AFC")]
	public string GetTextValue(string key, params object[] args)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F11")]
	[Cpp2IlInjected.Address(RVA = "0x479B10", Offset = "0x479B10", VA = "0x479B10")]
	public void SetFallbackCulture(GameCulture culture)
	{
	}
}
