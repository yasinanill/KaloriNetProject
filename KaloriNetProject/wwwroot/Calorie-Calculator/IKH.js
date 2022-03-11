document.getElementById('calorie-form').addEventListener('submit', function (e) {
    document.getElementById('results').style.display = 'none';

    document.getElementById('loading').style.display = 'block';

    setTimeout(calculateCalories, 2000);

    e.preventDefault();
});

function calculateCalories(e) {

   var gender = document.querySelector('input[name="customRadioInline1"]:checked');
    
    var height = document.getElementById('height');
    
    var IdealKilo = document.getElementById('total-calories');


    if (height.value === '') {
        errorMessage('Lutfen bosluklari doldurunuz')
    } else if (gender.id === 'male' ) {
        IdealKilo.value = (50 + (2.3 * (((height.value) / 2.54) - 60))).toFixed(2);

    } else if (gender.id === 'female') {
        (IdealKilo.value).toFixed(2) = (45.5 + (2.3 * (((height.value) / 2.54) - 60))).toFixed(2);

    } else {
        IdealKilo.value = (50 + (2.3 * (((height.value) / 2.54) - 60))).toFixed(2);
    }

    document.getElementById('results').style.display = 'block';

    document.getElementById('loading').style.display = 'none';
}

function errorMessage(error) {
    document.getElementById('results').style.display = 'none';

    document.getElementById('loading').style.display = 'none';
    const errorDiv = document.createElement('div');
    const card = document.querySelector('.card');
    const heading = document.querySelector('.heading');
    errorDiv.className = 'alert alert-danger';
    errorDiv.appendChild(document.createTextNode(error));

    card.insertBefore(errorDiv, heading);

    setTimeout(clearError, 4000);
}

function clearError() {
    document.querySelector('.alert').remove();
}

