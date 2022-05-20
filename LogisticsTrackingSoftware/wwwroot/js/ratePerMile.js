document.getElementById('ratePerMileForm').addEventListener('submit', calculateResults);


function calculateResults(e) {
    const paidMiles = document.getElementById("paid-Miles");
    const unpaidMiles = document.getElementById("unpaid-Miles");
    const loadPay = document.getElementById("load-Pay");
    const ratePerMile = document.getElementById("rate-Per-Mile");

    const paidMilesFloat = parseFloat(paidMiles.value);
    const unpaidMilesFloat = parseFloat(unpaidMiles.value);
    const loadPayFloat = parseFloat(loadPay.value);

    const results = loadPayFloat / (paidMilesFloat + unpaidMilesFloat);

    ratePerMile.value = results.toFixed(2);

    e.preventDefault();


}