<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo
 * Date: 11/26/2017
 * Time: 12:19 PM
 */

namespace AppBundle\Models;


class Calculator
{
    private $leftOperand;

    private $operator;

    private $rightOperand;

    private $result;

    /**
     * @return mixed
     */
    public function getRightOperand()
    {
        return $this->rightOperand;
    }

    /**
     * @param mixed $rightOperand
     */
    public function setRightOperand($rightOperand)
    {
        $this->rightOperand = $rightOperand;
    }

    /**
     * @return mixed
     */
    public function getLeftOperand()
    {
        return $this->leftOperand;
    }

    /**
     * @param mixed $leftOperand
     */
    public function setLeftOperand($leftOperand)
    {
        $this->leftOperand = $leftOperand;
    }

    /**
     * @return mixed
     */
    public function getOperator()
    {
        return $this->operator;
    }

    /**
     * @param mixed $operator
     */
    public function setOperator($operator)
    {
        $this->operator = $operator;
    }

    /**
     * @return mixed
     */
    public function getResult()
    {
        return $this->result;
    }

    /**
     * @param mixed $result
     */
    public function setResult($result)
    {
        $this->result = $result;
    }
}