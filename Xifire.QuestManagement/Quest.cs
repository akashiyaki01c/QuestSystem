namespace Xifire.QuestManagement;

/// <summary>
/// 一つのクエストを表すクラス
/// </summary>
public class Quest(string id, string name, QuestStatus status)
{
	public string Id => id;
	public string Name => name;
	public QuestStatus Status { get; set; } = status;
}

/// <summary>
/// クエスト
/// </summary>
public enum QuestStatus {
	/// <summary> 前(受注不可) </summary>
	NotAvailable,
	/// <summary> 前(受注可能) </summary>
	Available,
	/// <summary> 受注中 </summary>
	Ordering,
	/// <summary> 終了(成功) </summary>
	Successful,
	/// <summary> 終了(失敗) </summary>
	Failure,
}