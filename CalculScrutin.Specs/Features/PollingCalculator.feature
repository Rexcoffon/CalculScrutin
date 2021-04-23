Feature: PollingCalculator
	Returns the winner of a poll

#@poll1
Scenario: Get the winner of a poll
	Given The following candidates
		| Candidate |
		| Bob       |
		| Toto      |
		| Pierre    |
	And Add the votes
		# 11x Bob
		# 4x Toto
		# 6x Pierre
		| Vote   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Toto   |
		| Pierre |
		| Bob    |
		| Toto   |
		| Toto   |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Toto   |
		| Pierre |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
	And Close the poll
	When Calculate the polling
	Then The result should be "Bob"
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 11              | Bob       |
		| 4               | Toto      |
		| 6               | Pierre    |

#@poll2
Scenario: Get the winner of a poll of 2 rounds
	Given The following candidates
		| Candidate |
		| Bob       |
		| Toto      |
		| Pierre    |
	And Add the votes
		# 8x Bob
		# 4x Toto
		# 6x Pierre
		| Vote   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Toto   |
		| Pierre |
		| Bob    |
		| Toto   |
		| Toto   |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Toto   |
		| Pierre |
		| Pierre |
	And Close the poll
	When Calculate the polling
	Then The result should be null
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 8               | Bob       |
		| 4               | Toto      |
		| 6               | Pierre    |
	Given The following candidates
		| Candidate |
		| Bob       |
		| Pierre    |
	And Add the votes
		# 10x Bob
		# 8x Pierre
		| Vote   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Bob    |
		| Pierre |
		| Pierre |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Pierre |
	And Set the for a second round
	And Close the poll
	When Calculate the polling
	Then The result should be "Bob"
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 10              | Bob       |
		| 8               | Pierre    |

#@poll3
# En cas d'égalité entre le 2ème et 3ème au premier tour les 2 passe au prochain tour.
# On a donc un tour avec 3 candidats
Scenario: Get the winner of a poll of 2 rounds with ties on the 2nd and 3rd
	Given The following candidates
		| Candidate |
		| Bob       |
		| Toto      |
		| Pierre    |
	And Add the votes
		# 8x Bob
		# 6x Toto
		# 6x Pierre
		| Vote   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Toto   |
		| Toto   |
		| Toto   |
		| Pierre |
		| Bob    |
		| Toto   |
		| Toto   |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Toto   |
		| Pierre |
		| Pierre |
	And Close the poll
	When Calculate the polling
	Then The result should be null
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 8               | Bob       |
		| 6               | Toto      |
		| 6               | Pierre    |
	Given The following candidates
		| Candidate |
		| Bob       |
		| Toto      |
		| Pierre    |
	And Add the votes
		# 10x Bob
		# 4x Toto
		# 8x Pierre
		| Vote   |
		| Bob    |
		| Toto   |
		| Toto   |
		| Toto   |
		| Toto   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Bob    |
		| Pierre |
		| Pierre |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Pierre |
	And Set the for a second round
	And Close the poll
	When Calculate the polling
	Then The result should be "Bob"
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 10              | Bob       |
		| 8               | Pierre    |
		| 4               | Toto      |

#@poll4
# Les votes blancs son comptés normalements
Scenario: Get the winner of a poll with blank vote
	Given The following candidates
		| Candidate |
		| Bob       |
		| Toto      |
		| Pierre    |
	And Add the votes
		# 15x Bob
		# 4x Toto
		# 6x Pierre
		# 3x tutu (vote blanc)
		#1x blanc
		| Vote   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Toto   |
		| Pierre |
		| Bob    |
		| tutu   |
		|        |
		| Toto   |
		| Toto   |
		| Bob    |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| Pierre |
		| Pierre |
		| Toto   |
		| Pierre |
		| Pierre |
		| Bob    |
		| Bob    |
		| Bob    |
		| tutu   |
		| tutu   |
		| Bob    |
		| Bob    |
		| Bob    |
		| Bob    |
	And Close the poll
	When Calculate the polling
	Then The result should be "Bob"
	And The number of votes per candidate should be
		| number of votes | Candidate |
		| 15              | Bob       |
		| 4               | Toto      |
		| 6               | Pierre    |