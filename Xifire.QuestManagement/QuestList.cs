namespace Xifire.QuestManagement;

/// <summary>
/// クエストの配列を表す
/// </summary>
/// <param name="dictionary"></param>
public class QuestList(IEnumerable<Quest> dictionary) {
	private Dictionary<string, Quest> _dictionary = new(dictionary.Select(v => KeyValuePair.Create(v.Id, v)));

    public Quest this[string key] => _dictionary[key];
}