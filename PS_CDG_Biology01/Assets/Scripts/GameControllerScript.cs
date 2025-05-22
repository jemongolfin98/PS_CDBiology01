using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{

    // Career Options
    private int geneticCounselor;
    private int foodScientist;
    private int microbiologist;
    private int forensicScientist;
    private int pharmaceuticalSalesRep;

    // Options
    // Options - Question 01
    private GameObject q01Option01;
    private GameObject q01Option02;
    private GameObject q01Option03;
    private GameObject q01Option04;
    private GameObject q01Option05;
    // Options - Question 02
    private GameObject q02Option01;
    private GameObject q02Option02;
    private GameObject q02Option03;
    private GameObject q02Option04;
    private GameObject q02Option05;
    // Options - Question 03
    private GameObject q03Option01;
    private GameObject q03Option02;
    private GameObject q03Option03;
    private GameObject q03Option04;
    private GameObject q03Option05;
    // Options - Question 04
    private GameObject q04Option01;
    private GameObject q04Option02;
    private GameObject q04Option03;
    private GameObject q04Option04;
    private GameObject q04Option05;
    // Options - Question 05
    private GameObject q05Option01;
    private GameObject q05Option02;
    private GameObject q05Option03;
    private GameObject q05Option04;
    private GameObject q05Option05;
    // Options - Question 06
    private GameObject q06Option01;
    private GameObject q06Option02;
    private GameObject q06Option03;
    private GameObject q06Option04;
    private GameObject q06Option05;
    // Options - Question 07
    private GameObject q07Option01;
    private GameObject q07Option02;
    private GameObject q07Option03;
    private GameObject q07Option04;
    private GameObject q07Option05;
    // Options - Question 08
    private GameObject q08Option01;
    private GameObject q08Option02;
    private GameObject q08Option03;
    private GameObject q08Option04;
    private GameObject q08Option05;
    // Options - Question 09
    private GameObject q09Option01;
    private GameObject q09Option02;
    private GameObject q09Option03;
    private GameObject q09Option04;
    private GameObject q09Option05;
    // Options - Question 10
    private GameObject q10Option01;
    private GameObject q10Option02;
    private GameObject q10Option03;
    private GameObject q10Option04;
    private GameObject q10Option05;
    // Options - Bonus Question
    private GameObject qBOption01;
    private GameObject qBOption02;
    private GameObject qBOption03;
    private GameObject qBOption04;
    private GameObject qBOption05;


    // Screens
    private GameObject startGameScreen;
    private GameObject question01Screen;
    private GameObject question02Screen;
    private GameObject question03Screen;
    private GameObject question04Screen;
    private GameObject question05Screen;
    private GameObject question06Screen;
    private GameObject question07Screen;
    private GameObject question08Screen;
    private GameObject question09Screen;
    private GameObject question10Screen;
    private GameObject questionBScreen;
    private GameObject geneticCounselorScreen;
    private GameObject foodScientistScreen;
    private GameObject microbiologistScreen;
    private GameObject forensicScientistScreen;
    private GameObject pharmaceuticalSalesRepScreen;

    // Buttons
    private GameObject q01NextButton;
    private GameObject q02NextButton;
    private GameObject q03NextButton;
    private GameObject q04NextButton;
    private GameObject q05NextButton;
    private GameObject q06NextButton;
    private GameObject q07NextButton;
    private GameObject q08NextButton;
    private GameObject q09NextButton;
    private GameObject q10NextButton;
    private GameObject qBNextButton;


    // Start is called before the first frame update
    void Start()
    {
        // Options
        // Options - Question 01
        q01Option01 = GameObject.Find("Q01Option01");
        q01Option02 = GameObject.Find("Q01Option02");
        q01Option03 = GameObject.Find("Q01Option03");
        q01Option04 = GameObject.Find("Q01Option04");
        q01Option05 = GameObject.Find("Q01Option05");
        // Options - Question 01
        q02Option01 = GameObject.Find("Q02Option01");
        q02Option02 = GameObject.Find("Q02Option02");
        q02Option03 = GameObject.Find("Q02Option03");
        q02Option04 = GameObject.Find("Q02Option04");
        q02Option05 = GameObject.Find("Q02Option05");
        // Options - Question 01
        q03Option01 = GameObject.Find("Q03Option01");
        q03Option02 = GameObject.Find("Q03Option02");
        q03Option03 = GameObject.Find("Q03Option03");
        q03Option04 = GameObject.Find("Q03Option04");
        q03Option05 = GameObject.Find("Q03Option05");
        // Options - Question 01
        q04Option01 = GameObject.Find("Q04Option01");
        q04Option02 = GameObject.Find("Q04Option02");
        q04Option03 = GameObject.Find("Q04Option03");
        q04Option04 = GameObject.Find("Q04Option04");
        q04Option05 = GameObject.Find("Q04Option05");
        // Options - Question 01
        q05Option01 = GameObject.Find("Q05Option01");
        q05Option02 = GameObject.Find("Q05Option02");
        q05Option03 = GameObject.Find("Q05Option03");
        q05Option04 = GameObject.Find("Q05Option04");
        q05Option05 = GameObject.Find("Q05Option05");
        // Options - Question 01
        q06Option01 = GameObject.Find("Q06Option01");
        q06Option02 = GameObject.Find("Q06Option02");
        q06Option03 = GameObject.Find("Q06Option03");
        q06Option04 = GameObject.Find("Q06Option04");
        q06Option05 = GameObject.Find("Q06Option05");
        // Options - Question 01
        q07Option01 = GameObject.Find("Q07Option01");
        q07Option02 = GameObject.Find("Q07Option02");
        q07Option03 = GameObject.Find("Q07Option03");
        q07Option04 = GameObject.Find("Q07Option04");
        q07Option05 = GameObject.Find("Q07Option05");
        // Options - Question 01
        q08Option01 = GameObject.Find("Q08Option01");
        q08Option02 = GameObject.Find("Q08Option02");
        q08Option03 = GameObject.Find("Q08Option03");
        q08Option04 = GameObject.Find("Q08Option04");
        q08Option05 = GameObject.Find("Q08Option05");
        // Options - Question 01
        q09Option01 = GameObject.Find("Q09Option01");
        q09Option02 = GameObject.Find("Q09Option02");
        q09Option03 = GameObject.Find("Q09Option03");
        q09Option04 = GameObject.Find("Q09Option04");
        q09Option05 = GameObject.Find("Q09Option05");
        // Options - Question 01
        q10Option01 = GameObject.Find("Q10Option01");
        q10Option02 = GameObject.Find("Q10Option02");
        q10Option03 = GameObject.Find("Q10Option03");
        q10Option04 = GameObject.Find("Q10Option04");
        q10Option05 = GameObject.Find("Q10Option05");
        // Options - Question 01
        qBOption01 = GameObject.Find("QBOption01");
        qBOption02 = GameObject.Find("QBOption02");
        qBOption03 = GameObject.Find("QBOption03");
        qBOption04 = GameObject.Find("QBOption04");
        qBOption05 = GameObject.Find("QBOption05");

        // Screens
        startGameScreen = GameObject.Find("StartGameScreen");
        question01Screen = GameObject.Find("Question01Screen");
        question02Screen = GameObject.Find("Question02Screen");
        question03Screen = GameObject.Find("Question03Screen");
        question04Screen = GameObject.Find("Question04Screen");
        question05Screen = GameObject.Find("Question05Screen");
        question06Screen = GameObject.Find("Question06Screen");
        question07Screen = GameObject.Find("Question07Screen");
        question08Screen = GameObject.Find("Question08Screen");
        question09Screen = GameObject.Find("Question09Screen");
        question10Screen = GameObject.Find("Question10Screen");
        questionBScreen = GameObject.Find("QuestionBScreen");
        //geneticCounselorScreen = GameObject.Find("GeneticCounselorScreen");
        //foodScientistScreen = GameObject.Find("FoodScientistScreen");
        //microbiologistScreen = GameObject.Find("MicrobiologistScreen");
        //forensicScientistScreen = GameObject.Find("ForensicScientistScreen");
        //pharmaceuticalSalesRepScreen = GameObject.Find("PharmaceuticalSalesRepScreen");

        // Buttons
        q01NextButton = GameObject.Find("q01NextButton");
        q02NextButton = GameObject.Find("q02NextButton");
        q03NextButton = GameObject.Find("q03NextButton");
        q04NextButton = GameObject.Find("q04NextButton");
        q05NextButton = GameObject.Find("q05NextButton");
        q06NextButton = GameObject.Find("q06NextButton");
        q07NextButton = GameObject.Find("q07NextButton");
        q08NextButton = GameObject.Find("q08NextButton");
        q09NextButton = GameObject.Find("q09NextButton");
        q10NextButton = GameObject.Find("q10NextButton");
        qBNextButton = GameObject.Find("qBNextButton");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        startGameScreen.SetActive(false);
        question01Screen.SetActive(true);
    }

    public void Q01Option01()
    {
        q01Option01.SetActive(true);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        geneticCounselor += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option02()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(true);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        foodScientist += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option03()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(true);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        microbiologist += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option04()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(true);
        q01Option05.SetActive(false);

        forensicScientist += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option05()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Completed()
    {
        question01Screen.SetActive(false);
        question02Screen.SetActive(true);
    }

    public void Q02Option01()
    {
        q02Option01.SetActive(true);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        geneticCounselor += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option02()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(true);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        foodScientist += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option03()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(true);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        microbiologist += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option04()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(true);
        q02Option05.SetActive(false);

        forensicScientist += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option05()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Completed()
    {
        question02Screen.SetActive(false);
        question03Screen.SetActive(true);
    }

    public void Q03Option01()
    {
        q03Option01.SetActive(true);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        geneticCounselor += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option02()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(true);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        foodScientist += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option03()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(true);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        microbiologist += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option04()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(true);
        q03Option05.SetActive(false);

        forensicScientist += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option05()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Completed()
    {
        question03Screen.SetActive(false);
        question04Screen.SetActive(true);
    }

    public void Q04Option01()
    {
        q04Option01.SetActive(true);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        geneticCounselor += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option02()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(true);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        foodScientist += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option03()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(true);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        microbiologist += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option04()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(true);
        q04Option05.SetActive(false);

        forensicScientist += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option05()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Completed()
    {
        question04Screen.SetActive(false);
        question05Screen.SetActive(true);
    }

    public void Q05Option01()
    {
        q05Option01.SetActive(true);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        geneticCounselor += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option02()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(true);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        foodScientist += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option03()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(true);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        microbiologist += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option04()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(true);
        q05Option05.SetActive(false);

        forensicScientist += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option05()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Completed()
    {
        question05Screen.SetActive(false);
        question06Screen.SetActive(true);
    }

    public void Q06Option01()
    {
        q06Option01.SetActive(true);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        geneticCounselor += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option02()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(true);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        foodScientist += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option03()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(true);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        microbiologist += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option04()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(true);
        q06Option05.SetActive(false);

        forensicScientist += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option05()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Completed()
    {
        question06Screen.SetActive(false);
        question07Screen.SetActive(true);
    }

    public void Q07Option01()
    {
        q07Option01.SetActive(true);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        geneticCounselor += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option02()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(true);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        foodScientist += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option03()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(true);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        microbiologist += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option04()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(true);
        q07Option05.SetActive(false);

        forensicScientist += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option05()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Completed()
    {
        question07Screen.SetActive(false);
        question08Screen.SetActive(true);
    }

    public void Q08Option01()
    {
        q08Option01.SetActive(true);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        geneticCounselor += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option02()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(true);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        foodScientist += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option03()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(true);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        microbiologist += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option04()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(true);
        q08Option05.SetActive(false);

        forensicScientist += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option05()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Completed()
    {
        question08Screen.SetActive(false);
        question09Screen.SetActive(true);
    }

    public void Q09Option01()
    {
        q09Option01.SetActive(true);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        geneticCounselor += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option02()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(true);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        foodScientist += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option03()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(true);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        microbiologist += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option04()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(true);
        q09Option05.SetActive(false);

        forensicScientist += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option05()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Completed()
    {
        question09Screen.SetActive(false);
        question10Screen.SetActive(true);
    }

    public void Q10Option01()
    {
        q10Option01.SetActive(true);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        geneticCounselor += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option02()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(true);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        foodScientist += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option03()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(true);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        microbiologist += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option04()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(true);
        q10Option05.SetActive(false);

        forensicScientist += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option05()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Completed()
    {
        question10Screen.SetActive(false);
        //question02Screen.SetActive(true);

        if ((geneticCounselor > foodScientist) && (geneticCounselor > microbiologist) && (geneticCounselor > forensicScientist) && (geneticCounselor > pharmaceuticalSalesRep))
        {
            geneticCounselorScreen.SetActive(true);
        }
        else if ((foodScientist > geneticCounselor) && (foodScientist > microbiologist) && (foodScientist > forensicScientist) && (foodScientist > pharmaceuticalSalesRep))
        {
            foodScientistScreen.SetActive(true);
        }
        else if ((microbiologist > foodScientist) && (microbiologist > geneticCounselor) && (microbiologist > forensicScientist) && (microbiologist > pharmaceuticalSalesRep))
        {
            microbiologistScreen.SetActive(true);
        }
        else if ((forensicScientist > foodScientist) && (forensicScientist > microbiologist) && (forensicScientist > geneticCounselor) && (forensicScientist > pharmaceuticalSalesRep))
        {
            forensicScientistScreen.SetActive(true);
        }
        else if ((pharmaceuticalSalesRep > foodScientist) && (pharmaceuticalSalesRep > microbiologist) && (pharmaceuticalSalesRep > forensicScientist) && (pharmaceuticalSalesRep > geneticCounselor))
        {
            pharmaceuticalSalesRepScreen.SetActive(true);
        }
        else
        {
            questionBScreen.SetActive(true);
        }
    }

    public void QBOption01()
    {
        qBOption01.SetActive(true);
        qBOption02.SetActive(false);
        qBOption03.SetActive(false);
        qBOption04.SetActive(false);
        qBOption05.SetActive(false);

        geneticCounselor += 1;
        qBNextButton.SetActive(true);
    }
    public void QBOption02()
    {
        qBOption01.SetActive(false);
        qBOption02.SetActive(true);
        qBOption03.SetActive(false);
        qBOption04.SetActive(false);
        qBOption05.SetActive(false);

        foodScientist += 1;
        qBNextButton.SetActive(true);
    }
    public void QBOption03()
    {
        qBOption01.SetActive(false);
        qBOption02.SetActive(false);
        qBOption03.SetActive(true);
        qBOption04.SetActive(false);
        qBOption05.SetActive(false);

        microbiologist += 1;
        qBNextButton.SetActive(true);
    }
    public void QBOption04()
    {
        qBOption01.SetActive(false);
        qBOption02.SetActive(false);
        qBOption03.SetActive(false);
        qBOption04.SetActive(true);
        qBOption05.SetActive(false);

        forensicScientist += 1;
        qBNextButton.SetActive(true);
    }
    public void QBOption05()
    {
        qBOption01.SetActive(false);
        qBOption02.SetActive(false);
        qBOption03.SetActive(false);
        qBOption04.SetActive(false);
        qBOption05.SetActive(true);

        pharmaceuticalSalesRep += 1;
        qBNextButton.SetActive(true);
    }
    public void QBCompleted()
    {
        if ((geneticCounselor > foodScientist) && (geneticCounselor > microbiologist) && (geneticCounselor > forensicScientist) && (geneticCounselor > pharmaceuticalSalesRep))
        {
            geneticCounselorScreen.SetActive(true);
        }
        else if ((foodScientist > geneticCounselor) && (foodScientist > microbiologist) && (foodScientist > forensicScientist) && (foodScientist > pharmaceuticalSalesRep))
        {
            foodScientistScreen.SetActive(true);
        }
        else if ((microbiologist > foodScientist) && (microbiologist > geneticCounselor) && (microbiologist > forensicScientist) && (microbiologist > pharmaceuticalSalesRep))
        {
            microbiologistScreen.SetActive(true);
        }
        else if ((forensicScientist > foodScientist) && (forensicScientist > microbiologist) && (forensicScientist > geneticCounselor) && (forensicScientist > pharmaceuticalSalesRep))
        {
            forensicScientistScreen.SetActive(true);
        }
        else if ((pharmaceuticalSalesRep > foodScientist) && (pharmaceuticalSalesRep > microbiologist) && (pharmaceuticalSalesRep > forensicScientist) && (pharmaceuticalSalesRep > geneticCounselor))
        {
            pharmaceuticalSalesRepScreen.SetActive(true);
        }
    }
}
