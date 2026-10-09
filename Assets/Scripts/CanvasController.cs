using UnityEngine.UI;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] Text box;
    [SerializeField] Text action;

    public void UpdateInfo(PathMarker node, bool isGoal)
    {
        string info = "Current Node: location = x." + node.location.x + " z." + node.location.z +
            "\n \t g = " + node.G +
            "\n \t f = " + node.F +
            "\n \t h = " + node.H +
            "\nNode type = ";
        if (node.parent == null)
        {
            info += "<color=green>start</color>";
            box.text = info;
            return;
        }

        if (isGoal)
            info += "<color=yellow>goal</color>";
        else
            info += "<color=red>path</color>";

        box.text = info;
    }

    public void UpdateAction(string info)
    {
        action.text = info;
    }
}
