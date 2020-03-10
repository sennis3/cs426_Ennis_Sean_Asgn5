using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RedScoreScript : NetworkBehaviour
{
    public Text scoreText;
    int motherboardScore;
    public int processorScore;
    public int memoryScore;
    public int hardDriveScore;
    public int graphicsCardScore;


    // Start is called before the first frame update
    void Start()
    {
        motherboardScore = 0;
        processorScore = 0;
        memoryScore = 0;
        hardDriveScore = 0;
        graphicsCardScore = 0;

        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;
    }



    // Update is called once per frame
    public void AddMotherboardPoint()
    {
        motherboardScore = 1;
        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;

        if ((motherboardScore + processorScore + memoryScore + hardDriveScore + graphicsCardScore) == 5)
            RedWins();

    }

    public void AddProcessorPoint()
    {
        //processorScore++;
        processorScore = 1;
        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;

        if ((motherboardScore + processorScore + memoryScore + hardDriveScore + graphicsCardScore) == 5)
            RedWins();

    }

    public void AddMemoryPoint()
    {
        //memoryScore++;
        memoryScore = 1;
        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;

        if ((motherboardScore + processorScore + memoryScore + hardDriveScore + graphicsCardScore) == 5)
            RedWins();

    }

    public void AddHDDPoint()
    {
        //hardDriveScore++;
        hardDriveScore = 1;
        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;

        if ((motherboardScore + processorScore + memoryScore + hardDriveScore + graphicsCardScore) == 5)
            RedWins();

    }

    public void AddGPUPoint()
    {
        //graphicsCardScore++;
        graphicsCardScore = 1;
        scoreText.text = "<b>Red Zone</b>\n";
        scoreText.text = scoreText.text + "Motherboards: " + motherboardScore;
        scoreText.text = scoreText.text + "\nProcessors: " + processorScore;
        scoreText.text = scoreText.text + "\nMemory: " + memoryScore;
        scoreText.text = scoreText.text + "\nHard Drives: " + hardDriveScore;
        scoreText.text = scoreText.text + "\nGraphics Cards: " + graphicsCardScore;

        if ((motherboardScore + processorScore + memoryScore + hardDriveScore + graphicsCardScore) == 5)
            RedWins();

    }

    public void RedWins()
    {
        scoreText.text = "<b>Red Wins</b>";
        scoreText.fontSize = 14;
    }
}
