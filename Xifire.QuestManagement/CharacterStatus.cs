namespace Xifire.QuestManagement;

/// <summary>
/// キャラクタのステータス
/// </summary>
/// <param name="items"></param>
public class CharacterStatus(List<(Item, int)> items) {
	/// <summary>
	/// 所持アイテム
	/// </summary>
	public List<(Item, int)> Items = items ?? [];
}

/// <summary>
/// アイテム
/// </summary>
/// <param name="id"></param>
public class Item(string id) {
	public string Id => id;
}