document.getElementById('calorie-form').addEventListener('submit', function (e) {
    document.getElementById('results').style.display = 'none';

    document.getElementById('loading').style.display = 'block';

    setTimeout(calculateCalories, 2000);

    e.preventDefault();
});

function calculateCalories(e) {

   

    const height = document.getElementById('height');

    var totalCalories = document.getElementById('total-calories');
    


    const weight = document.getElementById('weight');

    if (height.value === '') {
        errorMessage('Lutfen bosluklari doldurunuz')
        
    } else {
        totalCalories.value =  weight.value / (((height.value) * (height.value) ) / 10000);
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

