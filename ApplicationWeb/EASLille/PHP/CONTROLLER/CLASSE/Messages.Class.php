<?php

class Messages
{

	/*****************Attributs***************** */

	private $_IdMessage;
	private $_Auteur;
	private $_Contenu;
	private $_Create_at;
	private static $_attributes = ["IdMessage", "Auteur", "Contenu", "Create_at"];
	/***************** Accesseurs ***************** */


	public function getIdMessage()
	{
		return $this->_IdMessage;
	}

	public function setIdMessage(?int $IdMessage)
	{
		$this->_IdMessage = $IdMessage;
	}
	public function getAuteur()
	{
		return $this->_Auteur;
	}

	public function setAuteur(?string $Auteur)
	{
		$this->_Auteur = $Auteur;
	}

	public function getContenu()
	{
		return $this->_Contenu;
	}

	public function setContenu(?string $Contenu)
	{
		$this->_Contenu = $Contenu;
	}

	public function getCreate_at()
	{
		return is_null($this->_Create_at)?null:$this->_Create_at->format('Y-n-j');
	}

	public function setCreate_at(?string $Create_at)
	{
		$this->_Create_at=is_null($Create_at)?null:DateTime::createFromFormat("Y-n-j",$Create_at);
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
		return "IdMessage : " . $this->getIdMessage() .  "Dates : "  . "Auteur : " . $this->getAuteur() .  "Contenu : " . $this->getContenu() . "Create_at : " . $this->getCreate_at() . "\n";
	}

	
}
