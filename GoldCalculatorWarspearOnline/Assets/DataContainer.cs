using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RimuruDev
{
    public sealed class DataContainer : MonoBehaviour
    {
        //[Header("UI")]

        public double[] array = { 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

        [Header("Exchange Rate Panel")]
        public TMP_InputField exchangeRate;
        public TMP_Text currentExchangeRateText;
        [Space]
        public double currentExchangeRateRub;

        [Header("Calculator Panel")]
        public TMP_InputField enterNewGoldExchange;
        public TMP_InputField enterNewRubExchange;
        [Space]
        public TMP_Text goldRubResultText;
        public TMP_Text rubGoldResultText;

        private void OnValidate()
        {
            if (currentExchangeRateRub <= 0f)
                currentExchangeRateRub = 1.7d;
        }
    }
}