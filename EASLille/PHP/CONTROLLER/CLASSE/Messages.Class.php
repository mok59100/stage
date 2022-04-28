<?php

class Messages
{

	/*****************Attributs***************** */

	private $_IdMessage;
	private $_Dates;
	private $_Heure;
	private $_Auteur;
	private $_Message;
	private static $_attributes = ["IdMessage", "Dates", "Heure", "Auteur", "Message"];
	/***************** Accesseurs ***************** */


	public function getIdMessage()
	{
		return $this->_IdMessage;
	}

	public function setIdMessage(?int $IdMessage)
	{
		$this->_IdMessage = $IdMessage;
	}

	public function getDates()
	{
		return $this->_Dates;
	}

	public function setDates(?string $Dates)
	{

		// $this->_Dates = is_null($Dates) ? null : DateTime::createFromFormat("Y-n-j", $Dates);
		$this->_Dates = $Dates;
	}
	public function getHeure()
	{
		return $this->_Heure;
	}

	public function setHeure(?string $Heure)
	{
		// $this->_Heure = is_null($Heure) ? null : DateTime::createFromFormat(" h:i:s", $Heure);
		$this->_Heure = $Heure;
	}
	public function getAuteur()
	{
		return $this->_Auteur;
	}

	public function setAuteur(?string $Auteur)
	{
		$this->_Auteur = $Auteur;
	}

	public function getMessage()
	{
		return $this->_Message;
	}

	public function setMessage(?string $Message)
	{
		$this->_Message = $Message;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
		foreach ($data as $key => $value) {
			$methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value === "" ? null : $value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	 * Transforme l'objet en chaine de caractères
	 *
	 * @return String
	 */
	public function toString()
	{
		return "IdMessage : " . $this->getIdMessage() .  "Dates : " . $this->getDates() . "Heure : " . $this->getHeure() . "Auteur : " . $this->getAuteur() .  "Message : " . $this->getMessage() . "\n";
	}
}
