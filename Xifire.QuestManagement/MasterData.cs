namespace Xifire.QuestManagement;

/// <summary>
/// マスタデータを表す
/// </summary>
public static class MasterData {
	public static SaveData Master => new(new([
		new ("1", "一番最初", QuestStatus.Available),
		new ("2", "一番最初が終わったら可能だね", QuestStatus.NotAvailable),
		new ("3", "一番最初が終わったら可能だね", QuestStatus.NotAvailable),
		new ("4", "2番が終わったら可能だね", QuestStatus.NotAvailable),
		new ("5", "3番が終わったら可能だね", QuestStatus.NotAvailable),
		new ("6", "2番が終わって3番を受注してなかったら可能だね", QuestStatus.NotAvailable),
	]), new CharacterStatus([
		(new("アイテム1"), 1),
		(new("アイテム2"), 1),
	]));
}