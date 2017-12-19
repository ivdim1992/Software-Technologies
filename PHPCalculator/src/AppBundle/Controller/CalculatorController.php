<?php

namespace AppBundle\Controller;

use AppBundle\Models\Calculator;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

class CalculatorController extends Controller
{
    /**
     * @Route("/calculator",name="view_calculator",methods={"GET"})
     */
    public function viewAction(){
        $form = $this->createForm(Calculator::class);

        return $this -> render(
            "calculator/view.html.twig",
            [
                'form' => $form->createView()
            ]
        );
    }
}
