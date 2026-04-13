window.renderProgressChart = (labels, data) => {

    const ctx = document.getElementById("progressChart");

    new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Workout volume',
                data: data,
                borderColor: '#FF8225',
                backgroundColor: 'rgba(255,130,37,0.2)',
                tension: 0.3,
                fill: true
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    labels: {
                        color: "white"
                    }
                }
            },
            scales: {
                x: {
                    ticks: { color: "white" }
                },
                y: {
                    ticks: { color: "white" }
                }
            }
        }
    });
};

// Progressionsgraf per övning – förstör gammal instans vid byte av övning
let progressionChartInstance = null;

window.renderProgressionChart = (labels, values) => {
    const ctx = document.getElementById('progressionChart').getContext('2d');

    if (progressionChartInstance) {
        progressionChartInstance.destroy();
    }

    progressionChartInstance = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Max weight (kg)',
                data: values,
                borderColor: '#FF8225',
                backgroundColor: 'rgba(255, 130, 37, 0.1)',
                borderWidth: 2,
                pointBackgroundColor: '#FF8225',
                tension: 0.3,
                fill: true
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    labels: { color: 'white' }
                }
            },
            scales: {
                y: {
                    beginAtZero: false,
                    ticks: { color: 'white' },
                    grid: { color: 'rgba(255,255,255,0.05)' }
                },
                x: {
                    ticks: { color: 'white' },
                    grid: { color: 'rgba(255,255,255,0.05)' }
                }
            }
        }
    });
};