// Gracze
function Player(name) {
	this.points = 0;
	this.name = name;
}

Player.prototype.play = function() {
	this.points += 1;
	mediator.played();
}

// Tablica wynikow
var scoreboard = {
	// aktualizowany elemt HTML
	element: document.getElementById('results'),
	// aktualizacja wyswietlacza
	update: function(score) {
		var i, msg = '';
		for (i in score) {
			if (score.hasOwnProperty(i)) {
				msg += '<p><strong>' + i + '<\/strong>: ';
				msg += score[i];
				msg += '<\/p>';
			}
		}
		this.element.innerHTML = msg;
	}
}

// Mediator
var mediator = {
	// wszyscy gracze
	players: {},
	
	// inicjalizacja
	setup: function() {
		var players = this.players;
		players.home = new Player('Gospodarze');
		players.guest = new Player('Goscie');
	},
	
	// ktos zagral uaktualnij wynikow
	played: function() {
		var players = this.players,
		score = {
			"Gospodarze": players.home.points,
			"Goscie": players.guest.points
		};
		scoreboard.update(score);
	},
	
	// obsluga interakcji z uzytkownikiem
	keypress: function (e) {
		e = e || window.event; // IE
		if (e.which === 49) { // klawisz "1"
			mediator.players.home.play();
			return;
		}
		
		if (e.which === 48) { // klawisz "0"
			mediator.players.guest.play();
			return;
		}
	}
}

// start!
mediator.setup();
window.onkeypress = mediator.keypress;

// gra konczy sie po 30 sekundach
setTimeout(function() {
	window.onkeyprerss = null;
	alert('Koniec gry!');
}, 30000);