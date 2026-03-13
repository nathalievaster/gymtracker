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