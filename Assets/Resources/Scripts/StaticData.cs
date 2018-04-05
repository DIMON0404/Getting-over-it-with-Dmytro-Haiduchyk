using UnityEngine;

public class StaticData {
    private static Vector3 playerTransformPosition;
    public static Vector3 _playerTransformPosition
    {
        get { return playerTransformPosition; }
        set
        {
            playerTransformPosition = value;
        }
    }
    private static Quaternion playerTransformRotation;
    public static Quaternion _playerTransformRotation
    {
        get { return playerTransformRotation; }
        set
        {
            playerTransformRotation = value;
        }
    }
    private static Vector3 handTransformPosition;
    public static Vector3 _handTransformPosition
    {
        get { return handTransformPosition; }
        set
        {
            handTransformPosition = value;
        }
    }
    private static Quaternion handTransformRotation;
    public static Quaternion _handTransformRotation
    {
        get { return handTransformRotation; }
        set
        {
            handTransformRotation = value;
        }
    }

    public static bool isWin = false;
    public static bool isTied = false;
    public static bool saveExist = false;
    public static bool pressContinue = false;
}
