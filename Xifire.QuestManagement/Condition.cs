namespace Xifire.QuestManagement;

/// <summary>
/// クエスト達成/開始条件を表す
/// </summary>
/// <param name="id"></param>
/// <param name="count"></param>
public abstract class Condition(string id, int count) {
	public string Id => id;
	public int Count => count;
	public abstract bool IsValid(SaveData saveData);
}
/// <summary>
/// クエスト開始/達成条件の種類
/// </summary>
public enum ConditionType {
	/// <summary> クエストが終了している </summary>
	QuestFinished,
	/// <summary> クエストが開始している </summary>
	QuestStarting,
	/// <summary> アイテムを所持している </summary>
	HasItem,
	/// <summary> アイテムを所持していない </summary>
	DoNotHasItem,
}
public static class ConditionFactory {
	public static Condition New(ConditionType type, string id, int count) {
        return type switch
        {
            ConditionType.QuestFinished => new QuestFinishedCondition(id, count),
            ConditionType.QuestStarting => new QuestStartingCondition(id, count),
            ConditionType.HasItem => new HasItemCondition(id, count),
            ConditionType.DoNotHasItem => new DoNotHasItemCondition(id, count),
            _ => throw new NotImplementedException(),
        };
    }
}

public class QuestFinishedCondition(string id, int count) : Condition(id, count) {
	public override bool IsValid(SaveData data) {
		return data.Quests[Id].Status == QuestStatus.Successful || data.Quests[Id].Status == QuestStatus.Failure;
	}
}
public class QuestStartingCondition(string id, int count) : Condition(id, count) {
	public override bool IsValid(SaveData data) {
		return data.Quests[Id].Status == QuestStatus.Ordering;
	}
}
public class HasItemCondition(string id, int count) : Condition(id, count) {
	public override bool IsValid(SaveData data) {
		return data.CharacterStatus.Items.Exists(v => v.Item1.Id == Id && v.Item2 == Count);
	}
}
public class DoNotHasItemCondition(string id, int count) : Condition(id, count) {
	public override bool IsValid(SaveData data) {
		return data.CharacterStatus.Items.Exists(v => v.Item1.Id != Id || v.Item2 != Count);
	}
}