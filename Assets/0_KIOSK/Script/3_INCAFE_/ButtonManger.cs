using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManger : MonoBehaviour
{
    public GameObject[] firstEnd = new GameObject[3];
    public GameObject firstStart;

    // - + 쪽에서 사용중임 texts
    public Text texts;
    //-  +쪽에서 사용중이다 text2
    public Text texts2;
    //마지막 가격표에 사용 text
    public Text textPriceCard;
    public Text textPriceCash;

    public GameObject forText;
    public GameObject forText2;

    bool isFirstPage = false;
    //커피
    bool isExprso = false;
    bool isAmericano = false;
    bool isCapuchino = false;
    bool isCafeLatte = false;
    
    //논커피
    bool isChoco = false;
    bool isGreen = false;
    bool isStroberry = false;
    bool isIceTea = false;

    //디저트
    bool isCookie = false;
    bool isMafin = false;
    bool isCrofle = false;
    bool isCake = false;

    bool isShout = false;
    bool isSizeUp = false;

    int i = 1;
    int i2 = 1;
    int price = 0;

    public GameObject toCoffee;

    //대분류 (커피, 논커피, 디저트)
    public GameObject coffee;
    public GameObject nonCoffee;
    public GameObject desert;

    //중분류 커피
    public GameObject expreso;
    public GameObject americano;
    public GameObject capuchno;
    public GameObject cafelatte;
    //중분류 논커피
    public GameObject choco;
    public GameObject greenTea;
    public GameObject stroberry;
    public GameObject iceTea;
    //중분류 디저트
    public GameObject cookie;
    public GameObject mafin;
    public GameObject crofle;
    public GameObject cake;

    //첫번째 주문내역이 있을 경우 두번째 주문내역 커피
    public GameObject expreso2;
    public GameObject americano2;
    public GameObject capuchno2;
    public GameObject cafelatte2;

    //첫번째 칸에 주문내역이 있을 경우 두번째 주문내역 논커피
    public GameObject choco2;
    public GameObject greenTea2;
    public GameObject stroberry2;
    public GameObject iceTea2;

    //첫번쨰 칸에 주문내역이 있을 경우 두번째 주문내영 디저트
    public GameObject cookie2;
    public GameObject mafin2;
    public GameObject crofle2;
    public GameObject cake2;

    //버튼을 눌렀을 때 추가메뉴
    public GameObject twoExpreso;
    public GameObject[] twoCoffee = new GameObject[3];
    public GameObject[] twoNonCoffee = new GameObject[4];
    public GameObject[] twoDesert = new GameObject[4];

    public GameObject threePage;
    public GameObject cardPage;
    public GameObject cashPage;

    private GameObject forPriceOBJ;
    private GameObject soundManager;
    Animator anim;
    SkipToKiosk forSkip = new SkipToKiosk();


    void Awake()
    {
        price = 0;
        forPriceOBJ = GameObject.Find("Text_PriceCard");
        anim = forPriceOBJ.GetComponent<Animator>();
        
        soundManager = GameObject.Find("SoundManager");
    }

    void Update()
    {
        // textPrice.text = price + "원";
    }

    //대분류 (커피 , 논커피, 디저트)
    public void First()
    {
        firstEnd[0].SetActive(false);
        firstEnd[1].SetActive(false);
        firstEnd[2].SetActive(false);

        firstStart.SetActive(true);

        Destroy(soundManager);
    }

    public void ToCoffee()
    {
        toCoffee.SetActive(true);
        Coffee();

    }

    public void Coffee()
    {
        coffee.SetActive(true);

        nonCoffee.SetActive(false);
        desert.SetActive(false);
    }

    public void NonCoffee()
    {
        nonCoffee.SetActive(true);

        coffee.SetActive(false);
        desert.SetActive(false);
    }

    public void Desert()
    {
        desert.SetActive(true);

        coffee.SetActive(false);
        nonCoffee.SetActive(false);

    }
    
    //중분류 Coffee
    public void Expreoso()
    {
        //에스프레스를 누르면
        twoExpreso.SetActive(true);
        price += 2500;
        print(price);
        
        //첫번쨰 칸에 차있을 때
        if (isFirstPage == true)
        {
            //첫번째 칸이 엑스프레소일떄
            if (isExprso == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }
            //첫번째 칸이 엑스페로사가 아닐떄
            else if (isExprso == false)
            {

                forText2.SetActive(true);
                expreso2.SetActive(true);
            
                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }
        }


        else if (isFirstPage == false)
        {
            forText.SetActive(true);
            expreso.SetActive(true);
            //엑스프레소 켜있을때
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);

            isFirstPage = true;
            isExprso = true;

            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
        
            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void Americano()
    {
        //아메리카노 누르면 추가메뉴
        twoCoffee[0].SetActive(true);
        price += 3500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 아메리카노일떄
            if (isAmericano == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isAmericano == false)
            {
                forText2.SetActive(true);
                americano2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }
        }

        else if (isFirstPage == false)
        {

            forText.SetActive(true);
            americano.SetActive(true);
            //아메리카노 켜있을때
            expreso.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);

            isFirstPage = true;
            isAmericano = true;

            isExprso = false;
            isCapuchino = false;
            isCafeLatte = false;
        
            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }

        
    }

    public void Capuchno()
    {
        twoCoffee[1].SetActive(true);
        price += 4500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 카푸치노일떄
            if (isCapuchino == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isCapuchino == false) 
            {
                forText2.SetActive(true);
                capuchno2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }
        }

        else if (isFirstPage == false)
        {       
            forText.SetActive(true);
            capuchno.SetActive(true);
            //카푸치노 켜있을때
            expreso.SetActive(false);
            americano.SetActive(false);
            cafelatte.SetActive(false);

            isFirstPage = true;
            isCapuchino = true;

            isExprso = false;
            isAmericano = false;
            isCafeLatte = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
        
    }

    public void Cafelatte()
    {
        twoCoffee[2].SetActive(true);
        price += 4500;
        print(price);
        if (isFirstPage == true)
        {
            //첫번째 칸이 카페라떼일떄
            if (isCafeLatte == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isCafeLatte == false)     
            {
                forText2.SetActive(true);
                cafelatte2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            forText.SetActive(true);
            cafelatte.SetActive(true);
            //카페라때가 켜있을때
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);

            isFirstPage = true;
            isCafeLatte = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

        //NonCoffee 부분
    public void Choco()
    {
        twoNonCoffee[0].SetActive(true);
        price += 5500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 초코일떄
            if (isChoco == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isChoco == false)     
            {
                forText2.SetActive(true);
                choco2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //초코가 켜있을때
            forText.SetActive(true);
            choco.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            iceTea.SetActive(false);

            isFirstPage = true;
            isChoco = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isIceTea = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void Green()
    {
        twoNonCoffee[1].SetActive(true);
        price += 5500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 그린티일떄
            if (isGreen == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isGreen == false)     
            {
                forText2.SetActive(true);
                greenTea2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            
            //그린티가 켜있을때
            forText.SetActive(true);
            greenTea.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            choco.SetActive(false);
            stroberry.SetActive(false);
            iceTea.SetActive(false);
            

            isFirstPage = true;
            isGreen = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isChoco = false;
            isStroberry = false;
            isIceTea = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void StroBerry()
    {
        twoNonCoffee[2].SetActive(true);
        price += 6000;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 딸기일떄
            if (isStroberry == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isStroberry == false)     
            {
                forText2.SetActive(true);
                stroberry2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //딸기가 켜있을때
            forText.SetActive(true);
            stroberry.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            choco.SetActive(false);
            greenTea.SetActive(false);
            iceTea.SetActive(false);

            isFirstPage = true;
            isStroberry = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isChoco = false;
            isIceTea = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void IceTea()
    {
        twoNonCoffee[3].SetActive(true);
        price += 3500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 초코일떄
            if (isIceTea == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isIceTea == false)     
            {
                forText2.SetActive(true);
                iceTea2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //초코가 켜있을때
            forText.SetActive(true);
            iceTea.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            choco.SetActive(false);

            isFirstPage = true;
            isIceTea = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
        
    }

    public void Cookie()
    {
        twoDesert[0].SetActive(true);
        price += 1500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 쿠키일떄
            if (isCookie == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isCookie == false)     
            {
                forText2.SetActive(true);
                cookie2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //쿠키가 켜있을때
            forText.SetActive(true);
            cookie.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            choco.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            mafin.SetActive(false);
            crofle.SetActive(false);
            cake.SetActive(false);

            isFirstPage = true;
            isCookie = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;
            isIceTea = false;

            isMafin = false;
            isCrofle = false;
            isCake = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void Mafin()
    {
        twoDesert[1].SetActive(true);
        price += 2500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 쿠키일떄
            if (isMafin == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isMafin == false)     
            {
                forText2.SetActive(true);
                mafin2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //머핀가 켜있을때
            forText.SetActive(true);
            mafin.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            choco.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            cookie.SetActive(false);
            crofle.SetActive(false);
            cake.SetActive(false);

            isFirstPage = true;
            isMafin = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;
            isIceTea = false;

            isCookie = false;
            isCrofle = false;
            isCake = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void Crofle()
    {
        twoDesert[2].SetActive(true);
        price += 5500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 쿠키일떄
            if (isCrofle == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isCrofle == false)     
            {
                forText2.SetActive(true);
                crofle2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //머핀가 켜있을때
            forText.SetActive(true);
            crofle.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            choco.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            cookie.SetActive(false);
            mafin.SetActive(false);
            cake.SetActive(false);

            isFirstPage = true;
            isCrofle = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;
            isIceTea = false;

            isCookie = false;
            isMafin = false;
            isCake = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    public void Cake()
    {
        twoDesert[3].SetActive(true);
        price += 4500;
        print(price);

        if (isFirstPage == true)
        {
            //첫번째 칸이 쿠키일떄
            if (isCake == true)
            {
                i = i + 1;
                texts.GetComponent<Text>().text = i.ToString("D");
            }

            else if (isCake == false)     
            {
                forText2.SetActive(true);
                cake2.SetActive(true);

                i2 = 1;
                texts2.GetComponent<Text>().text = i2.ToString("D");
            }

        }

        else if (isFirstPage == false)
        {
            //머핀가 켜있을때
            forText.SetActive(true);
            cake.SetActive(true);
            //커피
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피 
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            choco.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            cookie.SetActive(false);
            mafin.SetActive(false);
            crofle.SetActive(false);

            isFirstPage = true;
            isCake = true;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;
            isIceTea = false;

            isCookie = false;
            isMafin = false;
            isCrofle = false;

            i = 1;
            texts.GetComponent<Text>().text = i.ToString("D");
        }
    }

    

    //마이너스, 플러스 버튼
    public void Minues()
    {
        i = i - 1;
        texts.GetComponent<Text>().text = i.ToString("D");
        //가격표 커피
        if (isExprso == true)
        {
            price -= 2500;
            print(price);
        }

        else if (isAmericano == true)
        {
            price -= 3500;
            print(price);
        }

        else if (isCapuchino == true)
        {
            price -= 4500;
            print(price);
        }

        else if (isCafeLatte == true)
        {
            price -= 4500;
            print(price);
        }
        //가격표 논커피
        else if (isChoco == true)
        {
            price -= 5500;
            print(price);
        }

        else if (isGreen == true)
        {
            price -= 5500;
            print(price);
        }
        
        else if (isStroberry == true)
        {
            price -= 6000;
            print(price);
        }
        
        else if (isIceTea == true)
        {
            price -= 3500;
            print(price);
        }

        //가격표 디저트
        else if (isCookie == true)
        {
            price -= 1500;
            print(price);
        }

        else if (isMafin == true)
        {
            price -= 2500;
            print(price);
        }

        else if (isCrofle == true)
        {
            price -= 5500;
            print(price);
        }

        else if (isCake == true)
        {
            price -= 4500;
            print(price);
        }
  
        if (i <= 0)
        {
            //커피
            forText.SetActive(false);
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피
            choco.SetActive(false);
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            cookie.SetActive(false);
            mafin.SetActive(false);
            crofle.SetActive(false);
            cake.SetActive(false);

            isFirstPage = false;
        }
        
    }

    public void Pluss()
    {
        if (i >= 1)
        {
            i = i + 1;
            texts.GetComponent<Text>().text = i.ToString("D");

            if(isExprso == true)
            {
                price += 2500;
                print(price);
            }

            else if(isAmericano == true)
            {
                price += 3500;
                print(price);
            }

            else if (isCapuchino == true)
            {
                price += 4500;
                print(price);
            }

            else if (isCafeLatte == true)
            {
                price += 4500;
                print(price);
            }
            //가격표 논커피
            else if (isChoco == true)
            {
                price += 5500;
                print(price);
            }

            else if (isGreen == true)
            {
                price += 5500;
                print(price);
            }
            
            else if (isStroberry == true)
            {
                price += 6000;
                print(price);
            }
            
            else if (isIceTea == true)
            {
                price += 3500;
                print(price);
            }

            //가격표 디저트
            else if (isCookie == true)
            {
                price += 1500;
                print(price);
            }

            else if (isMafin == true)
            {
                price += 2500;
                print(price);
            }

            else if (isCrofle == true)
            {
                price += 5500;
                print(price);
            }

            else if (isCake == true)
            {
                price += 4500;
                print(price);
            }
        }
    }

    //마이너스2, 플러스2 버튼
    public void Minues2()
    {
        i2 = i2 -1;
        texts2.GetComponent<Text>().text = i2.ToString("D");

        if (isExprso == true)
        {
            price -= 2500;
            print(price);
        }

        else if (isAmericano == true)
        {
            price -= 3500;
            print(price);
        }

        else if (isCapuchino == true)
        {
            price -= 4500;
            print(price);
        }

        else if (isCafeLatte == true)
        {
            price -= 4500;
            print(price);
        }
        //가격표 논커피
        else if (isChoco == true)
        {
            price -= 5500;
            print(price);
        }

        else if (isGreen == true)
        {
            price -= 5500;
            print(price);
        }
        
        else if (isStroberry == true)
        {
            price -= 6000;
            print(price);
        }
        
        else if (isIceTea == true)
        {
            price -= 3500;
            print(price);
        }

        //가격표 디저트
        else if (isCookie == true)
        {
            price -= 1500;
            print(price);
        }

        else if (isMafin == true)
        {
            price -= 2500;
            print(price);
        }

        else if (isCrofle == true)
        {
            price -= 5500;
            print(price);
        }

        else if (isCake == true)
        {
            price -= 4500;
            print(price);
        }

        if (i2 <= 0)
        {
            //커피
            forText2.SetActive(false);
            expreso2.SetActive(false);
            americano2.SetActive(false);
            capuchno2.SetActive(false);
            cafelatte2.SetActive(false);

            //논커피
            choco2.SetActive(false);
            greenTea2.SetActive(false);
            stroberry2.SetActive(false);
            iceTea2.SetActive(false);
            //디저트
            cookie2.SetActive(false);
            mafin2.SetActive(false);
            crofle2.SetActive(false);
            cake2.SetActive(false);            

        }
        
    }

    public void Pluss2()
    {
        if (i2 >= 1)
        {
            i2 = i2 + 1;
            texts2.GetComponent<Text>().text = i2.ToString("D");

             if(isExprso == true)
            {
                price += 2500;
                print(price);
            }

            else if(isAmericano == true)
            {
                price += 3500;
                print(price);
            }

            else if (isCapuchino == true)
            {
                price += 4500;
                print(price);
            }

            else if (isCafeLatte == true)
            {
                price += 4500;
                print(price);
            }
            //가격표 논커피
            else if (isChoco == true)
            {
                price += 5500;
                print(price);
            }

            else if (isGreen == true)
            {
                price += 5500;
                print(price);
            }
            
            else if (isStroberry == true)
            {
                price += 6000;
                print(price);
            }
            
            else if (isIceTea == true)
            {
                price += 3500;
                print(price);
            }

            //가격표 디저트
            else if (isCookie == true)
            {
                price += 1500;
                print(price);
            }

            else if (isMafin == true)
            {
                price += 2500;
                print(price);
            }

            else if (isCrofle == true)
            {
                price += 5500;
                print(price);
            }

            else if (isCake == true)
            {
                price += 4500;
                print(price);
            }
        }
    }

    //취소하기 버튼
    public void Cansle()
    {
            //커피
            forText.SetActive(false);
            expreso.SetActive(false);
            americano.SetActive(false);
            capuchno.SetActive(false);
            cafelatte.SetActive(false);
            //논커피
            choco.SetActive(false);
            greenTea.SetActive(false);
            stroberry.SetActive(false);
            iceTea.SetActive(false);
            //디저트
            cookie.SetActive(false);
            mafin.SetActive(false);
            crofle.SetActive(false);
            cake.SetActive(false);


            //커피2
            forText2.SetActive(false);
            expreso2.SetActive(false);
            americano2.SetActive(false);
            capuchno2.SetActive(false);
            cafelatte2.SetActive(false);

            //논커피2
            choco2.SetActive(false);
            greenTea2.SetActive(false);
            stroberry2.SetActive(false);
            iceTea2.SetActive(false);
            //디저트2
            cookie2.SetActive(false);
            mafin2.SetActive(false);
            crofle2.SetActive(false);
            cake2.SetActive(false);

            isFirstPage = false;
            isCake = false;

            isExprso = false;
            isAmericano = false;
            isCapuchino = false;
            isCafeLatte = false;
            
            isGreen = false;
            isStroberry = false;
            isChoco = false;
            isIceTea = false;

            isCookie = false;
            isMafin = false;
            isCrofle = false; 

            price = 0;

    }
    //추가 메뉴 취소창
    public void Cansle2()
    {
        twoExpreso.SetActive(false);
        twoCoffee[0].SetActive(false);
        twoCoffee[1].SetActive(false);
        twoCoffee[2].SetActive(false);

        twoNonCoffee[0].SetActive(false);
        twoNonCoffee[1].SetActive(false);
        twoNonCoffee[2].SetActive(false);
        twoNonCoffee[3].SetActive(false);

        twoDesert[0].SetActive(false);
        twoDesert[1].SetActive(false);
        twoDesert[2].SetActive(false);
        twoDesert[3].SetActive(false);

        //취소 누르면 샷추가 했던 것들 값을 뺌
        if (isShout == true)
        {
            price -= 1000;
            print(price);
        }

        else if(isSizeUp == true)
        {
            price -= 1500;
            print(price);
        }

        else if (isShout == true && isSizeUp == true)
        {
            price -= 2500;
            print(price);
        }

    }

    public void Purchase()
    {
        twoExpreso.SetActive(false);
        twoCoffee[0].SetActive(false);
        twoCoffee[1].SetActive(false);
        twoCoffee[2].SetActive(false);

        twoNonCoffee[0].SetActive(false);
        twoNonCoffee[1].SetActive(false);
        twoNonCoffee[2].SetActive(false);
        twoNonCoffee[3].SetActive(false);

        twoDesert[0].SetActive(false);
        twoDesert[1].SetActive(false);
        twoDesert[2].SetActive(false);
        twoDesert[3].SetActive(false);

        print(price);
        price = price;
    }

    public void Cansle3()
    {
        threePage.SetActive(false);
        firstStart.SetActive(true);
    }

    public void Purchase2()
    {
        print(price);
        price = price;
        threePage.SetActive(true);
        if (price == 0)
        {
            threePage.SetActive(false);
            print("Choice Tea");
        }
    }

    public void CardPay()
    {
        print(price);
        price = price;
        cardPage.SetActive(true);

        textPriceCard.text = price + "원";

        anim.SetTrigger("isPrice");
    }
    public void CashPay()
    {
        print(price);
        price = price;
        cashPage.SetActive(true);

        textPriceCard.text = price + "원";

        anim.SetTrigger("isPrice");
    }

    public void AddShout()
    {
        if (isShout == false)
        {
            isShout = true;
            price += 1000;
            print(price);
        }

        else if (isShout == true)
        {
            isShout = false;
            price -= 1000;
            print(price);
        }
    }

    public void AddSizeUp()
    {
        if (isSizeUp == false)
        {
            isSizeUp = true;
            price += 1500;
            print(price);
        }

        else if (isSizeUp == true)
        {
            isSizeUp = false;
            price -= 1500;
            print(price);
        }
    }


}
