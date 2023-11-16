function Convertor(input) {
    let usd = Number(input[0]);
    let bgnEqual = 1.79549 * usd;
    console.log(bgnEqual);
}

Convertor(["22"]);
// Напишете функция за конвертиране на щатски долари (USD) в български лева (BGN). 
// Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.