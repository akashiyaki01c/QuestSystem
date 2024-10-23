namespace Xifire.QuestManagement;

/// <summary>
/// セーブデータを表す
/// </summary>
/// <param name="quests"></param>
/// <param name="status"></param>
public class SaveData(QuestList quests, CharacterStatus status) {
	public QuestList Quests { get; set; } = quests ?? new([]);
	public CharacterStatus CharacterStatus { get; set; } = status;
}